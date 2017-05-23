using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIClient
{
    public partial class HealthDialog : Form
    {
        private FirebirdInterface fb;
        public HealthDialog()
      
        {
            InitializeComponent();
        }
        //private void initRelation()
        //{
        //    fb.setRelation("relation4", fb.dataTable("PUPILS").Columns["P_ID_PUPIL"], fb.dataTable("HEALTH").Columns["H_ID_PUPIL"]);

        //}
        public DialogResult ShowDialog(FirebirdInterface fbObject)
        {
            fb = fbObject;
            bindingSource_hlt.DataSource = fb.dataTable("HEALTH");
            dataGridView_hlt.DataSource = bindingSource_hlt;
            dataGridView_hlt.Columns[0].Visible = false;
            //dataGridView_hlt.Columns[1].HeaderText = "ПІБ учня";
            dataGridView_hlt.Columns[2].HeaderText = "Група здоров'я";
            dataGridView_hlt.Columns[3].HeaderText = "Документ, що підтверджує стан здоров'я";
            dataGridView_hlt.Columns[4].HeaderText = "Дата початку звільнення від занять";
            dataGridView_hlt.Columns[5].HeaderText = "Дата закінчення звільнення від занять";
            initViewRelation("relation4", "ПІБ учня", 2);
            bindingNavigator_hlt.BindingSource = bindingSource_hlt;
            return base.ShowDialog();
        }
       
        private void initViewRelation(string relationName, string columName, int valueIndex)
        {
          
            try
            {
                DataRelation relation = fb.dataSet().Relations[relationName];

                string DataPropertyName = relation.ChildColumns[0].ColumnName;
                string DisplayMember = relation.ParentTable.Columns[valueIndex].ColumnName;
                string ValueMember = relation.ParentColumns[0].ColumnName;
                string tableName = relation.ParentTable.TableName;

                int fkIndex = fb.dataTable(relation.ChildTable.TableName).Columns.IndexOf(DataPropertyName);

                dataGridView_hlt.AllowUserToAddRows = true;
                dataGridView_hlt.Columns.Insert(fkIndex, new DataGridViewComboBoxColumn());
                dataGridView_hlt.Columns[fkIndex + 1].Visible = false;

                DataGridViewComboBoxColumn colum = dataGridView_hlt.Columns[fkIndex] as DataGridViewComboBoxColumn;
                if (colum != null)
                {
                    colum.Name = columName;                                       //Название колонки
                    colum.DataPropertyName = DataPropertyName;                    //Поле внешний ключ дочерней таблици
                    colum.DisplayMember = DisplayMember;                          //Отображаемое поле главной таблици 
                    colum.ValueMember = ValueMember;                              //Первичный ключ главной таблици
                    colum.DataSource = fb.dataTable(tableName);             //Заполняем колонку данными
                    colum.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;//Скрываем выпадающий список 
                }
                dataGridView_hlt.AllowUserToAddRows = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Помилка!", MessageBoxButtons.OK);
            }
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            bindingSource_hlt.EndEdit();
            if (!fb.save("HEALTH"))
            {
                MessageBox.Show("Збереження не виконано або не було оновлень БД");
            }
        }
    }
}
