using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Text.RegularExpressions;

#region
/// <summary>
/// WRITTEN BY TSOKOROV V.V. 07/06/2015
/// </summary>
#endregion

namespace UIClient
{
    public class FirebirdInterface
    {
        private List<FbDataAdapter> adapters;
        private FbConnection connect;
        private DataSet memory_db;

        public FbConnection ConnectionObject
        {
            get { return connect; }
        }

        public FirebirdInterface()
        {
            connect   = new FbConnection();
            adapters  = new List<FbDataAdapter>();
            memory_db = new DataSet();
        }

        private string queryGetTables()
        {
            return "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE (RDB$SYSTEM_FLAG = 0) AND (RDB$VIEW_SOURCE IS NULL) ORDER BY RDB$RELATION_NAME";
        }
        private string queryGetFields(string tableName)
        {
            return "SELECT R.RDB$FIELD_NAME, R.RDB$NULL_FLAG, T.RDB$TYPE_NAME, F.RDB$FIELD_LENGTH, F.RDB$FIELD_SCALE, F.RDB$FIELD_SUB_TYPE " +
                   "FROM RDB$TYPES T, RDB$RELATION_FIELDS R " +
                   "INNER JOIN RDB$FIELDS F ON F.RDB$FIELD_TYPE = T.RDB$TYPE AND T.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' " +
                   "WHERE F.RDB$FIELD_NAME = R.RDB$FIELD_SOURCE AND R.RDB$SYSTEM_FLAG = 0 AND RDB$RELATION_NAME = '" + tableName +
                   "' ORDER BY R.RDB$FIELD_POSITION ASC";
        }
        private DataColumn createDataColumn(string columnName, string typeName, int subType, bool allowDBNull, int lenght)
        {
            DataColumn column  = new DataColumn(columnName);
            column.AllowDBNull = allowDBNull;    
            switch (typeName)
            {
                case ("SHORT")    : { column.DataType = typeof(Int16); break; }
                case ("LONG")     : { column.DataType = typeof(Int32); break; }
                case ("INT64")    : { column.DataType = subType == 0 ? typeof(Int64) : typeof(Decimal); break; }
                case ("FLOAT")    : { column.DataType = typeof(Single); break; }
                case ("DOUBLE")   : { column.DataType = typeof(Double); break; }
                case ("DATE")     : { column.DataType = typeof(DateTime); column.DateTimeMode = DataSetDateTime.Local; break; }
                case ("TIMESTAMP"): { column.DataType = typeof(DateTime); column.DateTimeMode = DataSetDateTime.Local; break; }
                case ("TIME")     : { column.DataType = typeof(TimeSpan); break; }
                case ("TEXT")     : { column.DataType = typeof(String); column.MaxLength = lenght; break; }
                case ("VARYING")  : { column.DataType = typeof(String); column.MaxLength = lenght; break; }
                case ("CSTRING")  : { column.DataType = typeof(String); column.MaxLength = lenght; break; }
                case ("BLOB")     : { column.DataType = typeof(byte[]); column.MaxLength = lenght; break; }
            }
            return column;
        }
        private void loadTableColumn(string tableName)
        {
            int index = memory_db.Tables.IndexOf(tableName);
            if (index >= 0)
            {
                if (!isOpen()) openDataBase();

                DataTable table = new DataTable("FIELDSNAME");
                FbDataAdapter adapter = new FbDataAdapter(queryGetFields(tableName), connect);
                adapter.Fill(table);
                int tableCount = table.Rows.Count;
                for (int i = 0; i < tableCount; ++i)
                {
                    string columnName = table.Rows[i][0].ToString().TrimEnd();
                    bool allowDBNull = table.Rows[i][1] != DBNull.Value ? false : true;
                    string typeName = table.Rows[i][2].ToString().TrimEnd();
                    int lenght = table.Rows[i][3] != DBNull.Value ? Convert.ToInt32(table.Rows[i][3]) : 0;
                    int subTypeIndex = table.Rows[i][5] != DBNull.Value ? Convert.ToInt32(table.Rows[i][5]) : 0;
                    DataColumn column = createDataColumn(columnName, typeName, subTypeIndex, allowDBNull, lenght);
                    memory_db.Tables[index].Columns.Add(column);
                }

                memory_db.Tables[tableName].PrimaryKey = new DataColumn[] { memory_db.Tables[tableName].Columns[0] };
                memory_db.Tables[tableName].Columns[0].AutoIncrement = true;

                fillSchema(tableName);

                if (isOpen()) closeDataBase();
            }
        }

        public string initConnectString(string clientLibrary, string database, string userID, string password, string role, string charset, int port)
        {
            FbConnectionStringBuilder connectString = new FbConnectionStringBuilder();
            connectString.ClientLibrary = clientLibrary;
            connectString.Database = database;
            connectString.UserID = userID;
            connectString.Password = password;
            connectString.Charset = charset;
            connectString.Role = role;
            connectString.Port = port;
            connect.ConnectionString = connectString.ConnectionString;
            return connect.ConnectionString;
        }
  
        public bool openDataBase()
        {
            try
            {
                if (connect.ConnectionString.Length > 0)
                    connect.Open();
                else
                    throw new System.Exception("Строка соединения с БД не корректна.");
            }
            catch (System.Exception Except)
            {
                MessageBox.Show(Except.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
                return false;
            }
            return connect.State == System.Data.ConnectionState.Open ? true : false;
        }
        public bool closeDataBase()
        {
            try { connect.Close(); }
            catch (System.Exception Except)
            {
                MessageBox.Show(Except.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return connect.State == System.Data.ConnectionState.Closed ? true : false;
        }
        public bool isOpen()
        {
            return connect.State == System.Data.ConnectionState.Open ? true : false;
        }

        public List<string> listTables()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < memory_db.Tables.Count; ++i)
                list.Add(memory_db.Tables[i].TableName);
            return list;
        }
        public List<string> listColums(int indexTable)
        {
            List<string> list = new List<string>();
            if (tableName(indexTable) != string.Empty)
            {
                int count = memory_db.Tables[indexTable].Columns.Count;
                for (int i = 0; i < count; ++i)
                    list.Add(memory_db.Tables[indexTable].Columns[i].ColumnName);
            }
            return list;
        }

        public void loadTables()
        {
                if (!isOpen()) openDataBase();

                this.clear();

                Regex rgx = new Regex(@"\$");
                DataTable table = new DataTable("TABLESNAME");
                FbDataAdapter adapter = new FbDataAdapter(queryGetTables(), connect);
                
                adapter.Fill(table);

                int tableCount = table.Rows.Count;
                for (int i = 0, j = 0; i < tableCount; ++i)
                {
                    string item = table.Rows[i][j].ToString();
                    item = item.TrimEnd();
                    if (!rgx.IsMatch(item))
                    {
                        adapters.Add(new FbDataAdapter());
                        FbCommandBuilder commandBuilder = new FbCommandBuilder(adapters.Last());
                        commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
                        memory_db.Tables.Add(new DataTable(item));
                    }
                }
                if (isOpen()) closeDataBase();  
        }  

        public void fillSchema(string tableName)
        {
            try
            {
                int index = memory_db.Tables.IndexOf(tableName);
                if (index >= 0 && connect.ConnectionString.Length > 0)
                {
                    adapters[index].SelectCommand = new FbCommand("SELECT * FROM " + tableName, connect);
                    adapters[index].FillSchema(memory_db, System.Data.SchemaType.Mapped); 
                }
                else
                    throw new Exception("Ошибка! Не верное имя таблици или строка соединения");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int tableIndex(string name)
        {
            try
            {
                int index = memory_db.Tables.IndexOf(name);
                if (index == -1)
                    throw new Exception("Таблицы с данным именем не существует");
                return index;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public string tableName(int index)
        {
            try
            {
                if (index >= 0 && index <= memory_db.Tables.Count - 1)
                    return memory_db.Tables[index].TableName;
                else
                    throw new Exception("Таблицы с данным индексом не существует");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public DataTable dataTable(string tableName)
        {
            int index = tableIndex(tableName);
            if (index != -1)
                return memory_db.Tables[index];
            else
                return null;
        }
        public FbDataAdapter tableAdapter(string tableName)
        {
            int index = tableIndex(tableName);
            if (index != -1)
                return adapters[index];
            else
                return null;
        }

        public DataSet dataSet()
        {
            return memory_db;
        }

        public bool refill(string tableName)
        {
            try
            {
                int index = memory_db.Tables.IndexOf(tableName);
                if (index >= 0 && index <= memory_db.Tables.Count - 1)
                {
                    //memory_db.EnforceConstraints = false;
                    adapters[index].Fill(memory_db, tableName);
                    //memory_db.EnforceConstraints = true;

                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool fill(String tableName)
        {
            try
            {
                int index = memory_db.Tables.IndexOf(tableName);
                if (index >= 0 && index <= memory_db.Tables.Count - 1)
                {
                    if (memory_db.Tables.Contains(tableName))
                        memory_db.Tables[index].Clear();

                    this.loadTableColumn(tableName);
                    adapters[index].Fill(memory_db, tableName);

                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool save(string tableName)
        {
            DataTable currentTable = dataTable(tableName);
            if (currentTable.GetChanges() == null) return false;

            try
            {
                tableAdapter(tableName).Update(currentTable.GetChanges());
                currentTable.AcceptChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удается сохранить запись", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTable.RejectChanges();
                return false;
            }
        }

        public void clear()
        {
            adapters.Clear();
            memory_db.Relations.Clear();
            memory_db.Tables.Clear();
            memory_db.Clear();
        }
        public void clear(int index)
        {
            try
            {
                string item = tableName(index);
                if (item == string.Empty)
                {
                    adapters.Remove(adapters[index]);
                    memory_db.Tables[index].Clear();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear(string tableName)
        {
            try
            {
                int index = tableIndex(tableName);
                if (index != -1)
                {
                    adapters.Remove(adapters[index]);
                    memory_db.Tables[index].Clear();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setRelation(string relationName, string parentTable, string primaryKey,  string childrenTable, string forigenKey)
        {
            try
            {
                memory_db.Relations.Add(new DataRelation(relationName, dataTable(parentTable).Columns[primaryKey], dataTable(childrenTable).Columns[forigenKey], true));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable executeQuery(string strQuery)
        {
            DataTable table = new DataTable("QUERY");
            FbDataAdapter adapter = new FbDataAdapter(strQuery, connect);
            adapter.Fill(table);
            return table;

            //try
            //{
            //    FbCommand    sqlCommand = new FbCommand(strQuery, connect);
            //    FbDataReader sqlReader = sqlCommand.ExecuteReader();
            //    while (sqlReader.Read())
            //    {
            //        object[] row = { sqlReader[0], sqlReader[1], sqlReader[2], sqlReader[3], sqlReader[4] };
            //        dataGridView1.Rows.Add(row);
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

    }
}
