using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

#region
/// <summary>
/// WRITTEN BY TSOKOROV V.V. 07/06/2015
/// </summary>
#endregion

namespace UIClient
{
    public partial class MainWindow : Form
    {
//--------------------------------------------------------------------------------
        public string currentTable;
        public FirebirdInterface fbObject;
        public DataView[] pupilsView;
        public DataView[] subjectView;
        public DataView[] progresView;
        public DataView[] absenceView;
        
        
        public  Dictionary<string, int> treePosition;

        private List<TreeNode> nodeList;
        private WidgetAgregat widget;
        private TreeNode currentNode;
        private bool isRun;
        private string titleReport;

        public PupilsBirthdayParam pupilsBirthdayParam;
        public TeacherNameParam teacherParamDlg;
        public PupilsNameParam pupilsParamDlg;
        public TeacherCategoryParam teacherCategoryParamDlg;
        public PupilsDialog pplDlg;
        public TeachersDialog tchDlg;
        public SubjectDialog sbjDlg;
        public ProgressDialog prgDlg;
        public AbsenceDialog absDlg;
        public ElectiveDialog elcDlg;
//--------------------------------------------------------------------------------

        public bool IsRun { get { return isRun; } }

        public MainWindow(FirebirdInterface fb)
        {
            fbObject = fb; isRun = true;
            currentNode = new TreeNode(); currentNode.Tag = 0;
            InitializeComponent();

            if (fbObject.openDataBase()) 
            {
                this.loadData();       
                this.buildTree(); 
                fbObject.closeDataBase();
            }
        }

        public DataRow findCurrentRow(DataGridView dgv)
        {
            CurrencyManager cManager =
                this.BindingContext[dgv.DataSource, dgv.DataMember]
                     as CurrencyManager;
            if (cManager == null || cManager.Count == 0)
                return null;

            DataRowView drv = cManager.Current as DataRowView;
            return drv.Row;
        }
        private void buildTree()
        {
            DataTable CLASSES = fbObject.dataTable("CLASS");
            DataTable PUPILS = fbObject.dataTable("PUPILS");
            DataTable SUBJECT = fbObject.dataTable("SUBJECT");
            DataTable PROGRESS = fbObject.dataTable("PROGRESS");
            DataTable ABSENCE = fbObject.dataTable("ABSENCE");

            int count   = CLASSES.Rows.Count;
            pupilsView  = new DataView[count];
            subjectView = new DataView[count];
            progresView = new DataView[count];
            absenceView = new DataView[count];

            treePosition   = new Dictionary<string, int>();
            nodeList       = new List<TreeNode>();

            treeView.ImageList = imageList;
            TreeNode rootNode = treeView.Nodes.Add("Школа");
            rootNode.ImageIndex = rootNode.SelectedImageIndex = 0;
            rootNode.Tag = 0;
            nodeList.Add(rootNode);
            TreeNode childNode = rootNode.Nodes.Add("Классы");
            childNode.ImageIndex = childNode.SelectedImageIndex = 0;
            childNode.Tag = 0;
            nodeList.Add(childNode);
            for (int i = 0, j = 0; i < count; ++i)
            {
                string field0 = CLASSES.Rows[i][j].ToString(); //ID
                string field1 = CLASSES.Rows[i][j + 1].ToString();

                TreeNode items = childNode.Nodes.Add(field1);
                items.ImageIndex = items.SelectedImageIndex = 1;
                items.ContextMenuStrip = contextTreeMenu;
                items.Tag = 1;
                TreeNode item1 = items.Nodes.Add("Предметы");
                item1.ImageIndex = item1.SelectedImageIndex = 5;
                item1.Tag = 2;
                TreeNode item2 = items.Nodes.Add("Успеваемость");
                item2.ImageIndex = item2.SelectedImageIndex = 7;
                item2.Tag = 3;
                TreeNode item3 = items.Nodes.Add("Отсутствующие");
                item3.ImageIndex = item3.SelectedImageIndex = 6;
                item3.Tag = 4;
                treePosition.Add(items.Text, i);
                
                if (i == 0) 
                {
                    nodeList.Add(items);
                    nodeList.Add(item1);
                    nodeList.Add(item2);
                    nodeList.Add(item3);
                }
                
                string filterParemetr0 = "P_ID_CLASS = " + field0;
                string filterParemetr1 = "S_ID_CLASS = " + field0;
                string filterParemetr2 = "A_ID_CLASS = " + field0;

                pupilsView[i]  = new DataView(PUPILS, filterParemetr0, "P_ID_PUPIL", DataViewRowState.CurrentRows);
                subjectView[i] = new DataView(SUBJECT, filterParemetr1, "S_ID_SUBJECT", DataViewRowState.CurrentRows);
                progresView[i] = new DataView(PROGRESS, filterParemetr0, "P_ID_PROGRESS", DataViewRowState.CurrentRows);
                absenceView[i] = new DataView(ABSENCE, filterParemetr2, "A_ID_ABSENCE", DataViewRowState.CurrentRows);
            }

            TreeNode itemX = rootNode.Nodes.Add("Учителя");
            itemX.ImageIndex = itemX.SelectedImageIndex = 2;
            itemX.Tag = 5;
            nodeList.Add(itemX);

            TreeNode itemY = rootNode.Nodes.Add("Факультативы");
            itemY.ImageIndex = itemY.SelectedImageIndex = 8;
            itemY.Tag = 6;
            nodeList.Add(itemY);

            widget = new WidgetAgregat(this);

            rootNode.ExpandAll();
        }
        public void loadData()
        {
            List<string> tables = fbObject.listTables();    
            for (int i = 0; i < tables.Count; ++i)
                fbObject.fill(tables[i]);
            initRelation();
        }     
        private void initRelation()
        {
            fbObject.setRelation("relation1",  "NATIONALITY",   "N_ID_NATIONALITY",   "PUPILS",    "P_ID_NATIONALITY");
            fbObject.setRelation("relation2",  "CLASS",         "C_ID_CLASS",         "PUPILS",    "P_ID_CLASS");
            fbObject.setRelation("relation3",  "FAMILY",        "F_ID_FAMILY",        "PUPILS",    "P_ID_FAMILY");
            fbObject.setRelation("relation4",  "PUPILS",        "P_ID_PUPIL",         "HEALTH",    "H_ID_PUPIL");
            fbObject.setRelation("relation5",  "PUPILS",        "P_ID_PUPIL",         "PROGRESS",  "P_ID_PUPIL");
            fbObject.setRelation("relation6",  "PUPILS",        "P_ID_PUPIL",         "ABSENCE",   "A_ID_PUPIL");
            fbObject.setRelation("relation7",  "PUPILS",        "P_ID_PUPIL",         "ELECTIVE",  "E_ID_PUPIL");
            fbObject.setRelation("relation8",  "QUALIFICATION", "Q_ID_QUALIFICATION", "TEACHERS",  "T_ID_QUALIFICATION");
            fbObject.setRelation("relation9",  "EDUCATION",     "E_ID_EDUCATION",     "TEACHERS",  "T_ID_EDUCATION");
            fbObject.setRelation("relation10", "TEACHERS",      "T_ID_TEACHER",       "CLASS",     "C_ID_TEACHER");
            fbObject.setRelation("relation11", "TEACHERS",      "T_ID_TEACHER",       "SUBJECT",   "S_ID_TEACHER");
            fbObject.setRelation("relation12", "TEACHERS",      "T_ID_TEACHER",       "ELECTIVE",  "E_ID_TEACHER");
            fbObject.setRelation("relation13", "SUBJECT",       "S_ID_SUBJECT",       "PROGRESS",  "P_ID_SUBJECT");
            fbObject.setRelation("relation14", "CLASS",         "C_ID_CLASS",         "SUBJECT",   "S_ID_CLASS");
            fbObject.setRelation("relation15", "CLASS",         "C_ID_CLASS",         "PROGRESS",  "P_ID_CLASS");
            fbObject.setRelation("relation16", "CLASS",         "C_ID_CLASS",         "ABSENCE",   "A_ID_CLASS");
            
        }
        public void initViewRelation(string relationName, string columName, int indexDisplyColumn, int insertColumnIndex = 0, bool ComboBoxDisplayStyle = false, bool isEditTable = false)
        {
            try
            {
                DataRelation relation = fbObject.dataSet().Relations[relationName];

                string DataPropertyName = relation.ChildColumns[0].ColumnName;
                string DisplayMember = relation.ParentTable.Columns[indexDisplyColumn].ColumnName;
                string ValueMember = relation.ParentColumns[0].ColumnName;
                string tableName = relation.ParentTable.TableName;

                mainGrid.AllowUserToAddRows = true;
                mainGrid.Columns.Insert(insertColumnIndex, new DataGridViewComboBoxColumn());
                DataGridViewComboBoxColumn colum = mainGrid.Columns[insertColumnIndex] as DataGridViewComboBoxColumn;
                if (colum != null)
                {
                    colum.Name = columName;                                       //Название колонки
                    colum.DataPropertyName = DataPropertyName;                    //Поле внешний ключ дочерней таблици
                    colum.DisplayMember = DisplayMember;                          //Отображаемое поле главной таблици 
                    colum.ValueMember = ValueMember;                              //Первичный ключ главной таблици
                    colum.DataSource = relation.ParentTable;             //Заполняем колонку данными
                    colum.DisplayStyle = ComboBoxDisplayStyle == false ? DataGridViewComboBoxDisplayStyle.Nothing : 
                                                                         DataGridViewComboBoxDisplayStyle.ComboBox;
                }
                mainGrid.AllowUserToAddRows = isEditTable;
                mainGrid.ReadOnly = !isEditTable;
                mainGrid.SelectionMode = isEditTable == true ? DataGridViewSelectionMode.RowHeaderSelect : DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            isRun = false; this.Close();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            isRun = true; this.Close();
        }

        private void сloseWindow(object sender, FormClosedEventArgs e)
        {
            if(fbObject.isOpen()) fbObject.closeDataBase();
            isRun = isRun == false ? true : false;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDlg = new SettingsDialog();
            settingsDlg.ShowDialog();
        }

        private void selectNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(e.Node.Tag)];
            plymorphObject.Node = currentNode = e.Node;
            plymorphObject.adapt();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void selectRow(object sender, MouseEventArgs e)
        {
            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.showEditDialog();
        }

        private void NationalityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NationalityDialog dlg = new NationalityDialog();
            dlg.ShowDialog(fbObject);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.insertDialog();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            isRun = false; this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.showEditDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.deleteRow();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.dataSave();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.dataRefresh();
        }

        private void selectTeacher_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Teachers - 1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Teachers];
            plymorphObject.adaptFilterA();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;    
        }

        private void referenceQualification_Click(object sender, EventArgs e)
        {
            QualificationDialog dialog = new QualificationDialog();
            dialog.ShowDialog(fbObject);
        }

        private void referenceEducation_Click(object sender, EventArgs e)
        {
            EducationDialog dialog = new EducationDialog();
            dialog.ShowDialog(fbObject);
        }

        private void referenceFamily_Click(object sender, EventArgs e)
        {
            FamilyDialog dialog = new FamilyDialog();
            dialog.ShowDialog(fbObject);
        }

        private void referenceHealth_Click(object sender, EventArgs e)
        {
            HealthDialog dialog = new HealthDialog();
            dialog.ShowDialog(fbObject);
        }

        private void selectCategory_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Teachers-1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Teachers];
            plymorphObject.adaptFilterB();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; 
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDlg = new SettingsDialog();
            settingsDlg.ShowDialog();
        }

        private void selectLoading_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Subject-1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Subject];
            plymorphObject.adaptFilterA();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  
        }

        private void selectNamePupils_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Pupils-1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Pupils];
            plymorphObject.adaptFilterA();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  
        }

        private void selectProgress_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Progress - 1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Progress];
            plymorphObject.adaptFilterA();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  
        }

        private void selectAttendance_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Absence - 1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Absence];
            plymorphObject.adaptFilterA();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  
        }

        private void selectDateBirthday_Click(object sender, EventArgs e)
        {
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[(int)TableItems.Pupils - 1];
            plymorphObject.Node = currentNode = nodeList[(int)TableItems.Pupils];
            plymorphObject.adaptFilterB();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void generateReportPupilsList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Показать сначала диалог настройки печати?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                printDialog.ShowDialog();

            titleReport = "Список учеников";
            mainGrid.AllowUserToAddRows = false;
            mainGrid.ReadOnly           = true;
            mainGrid.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
            mainGrid.DataSource = fbObject.executeQuery("SELECT  PUPILS.P_NAME, PUPILS.P_BIRTH_DATE, CLASS.C_CLASSNANE FROM PUPILS INNER JOIN CLASS ON (PUPILS.P_ID_CLASS = CLASS.C_ID_CLASS)");
            mainGrid.Columns[0].HeaderText = "Фамилия Имя Отчество";
            mainGrid.Columns[1].HeaderText = "Дата рождения";
            mainGrid.Columns[2].HeaderText = "Класс";
            mainGrid.Columns[0].Width = 230;
            mainGrid.Columns[1].Width = 230;
            mainGrid.Columns[2].Width = 230;
            printDialog.UseEXDialog = true;

            printDocument.DocumentName = titleReport;
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.WindowState = FormWindowState.Maximized; 
            printPreviewDialog.ShowInTaskbar = true;
            printPreviewDialog.MinimizeBox = true;
            printPreviewDialog.PrintPreviewControl.Zoom = 1.5;
            printPreviewDialog.Height = 800;
            printPreviewDialog.Width = 1024;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            PrintRendering.printRendering(titleReport, mainGrid, e);

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            PlymorphicWidget plymorphObject = widget[Convert.ToInt32(currentNode.Tag)];
            plymorphObject.Node = currentNode;
            plymorphObject.adapt();

            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void cardLoadTeacher_Click(object sender, EventArgs e)
        {
            teacherParamDlg = new TeacherNameParam(fbObject);
            if (teacherParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filter = "'" + teacherParamDlg.cbTeacher.Text + "'";
                if (MessageBox.Show("Показать сначала диалог настройки печати?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    printDialog.ShowDialog();

                titleReport = "Нагрузка преподавателя";
                mainGrid.AllowUserToAddRows = false;
                mainGrid.ReadOnly = true;
                mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                mainGrid.DataSource = fbObject.executeQuery("SELECT TEACHERS.T_NAME, CLASS.C_CLASSNANE, SUBJECT.S_NAME, SUBJECT.S_HOURS FROM CLASS " +
                                                            "INNER JOIN SUBJECT ON (CLASS.C_ID_CLASS = SUBJECT.S_ID_CLASS) " +
                                                            "INNER JOIN TEACHERS ON (SUBJECT.S_ID_TEACHER = TEACHERS.T_ID_TEACHER) " +
                                                            "WHERE (TEACHERS.T_NAME = " + filter + ")");

                mainGrid.Columns[0].HeaderText = "Фамилия Имя Отчество";
                mainGrid.Columns[1].HeaderText = "Класс";
                mainGrid.Columns[2].HeaderText = "Название предмета";
                mainGrid.Columns[3].HeaderText = "Количество часов";
                mainGrid.Columns[0].Width = 230;
                mainGrid.Columns[1].Width = 230;
                mainGrid.Columns[2].Width = 230;
                mainGrid.Columns[3].Width = 230;
                printDialog.UseEXDialog = true;

                printDocument.DocumentName = titleReport;
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.WindowState = FormWindowState.Maximized;
                printPreviewDialog.ShowInTaskbar = true;
                printPreviewDialog.MinimizeBox = true;
                printPreviewDialog.PrintPreviewControl.Zoom = 1.5;
                printPreviewDialog.Height = 800;
                printPreviewDialog.Width = 1024;
                printPreviewDialog.ShowDialog();
            }
        }

        private void aboutApp_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }





    }



}
