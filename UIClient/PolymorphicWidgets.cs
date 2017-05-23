using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

#region
/// <summary>
/// WRITTEN BY TSOKOROV V.V. 07/06/2015
/// </summary>
#endregion

namespace UIClient
{
    public enum TableItems { School  = 0, Classes  = 1, Pupils  = 2, Subject  = 3,
                             Progress = 4, Absence = 5, Teachers = 6, Elective = 7 }

    public class PlymorphicWidget
    {
        protected TreeNode nodeData;
        protected MainWindow widget;

        public PlymorphicWidget(MainWindow window)
        {
            widget = window;
        }

        protected virtual void view(){}
        public virtual void adaptFilterA() 
        {
            widget.mainGrid.DataSource = null;
        }
        public virtual void adaptFilterB()
        {
            widget.mainGrid.DataSource = null;
        }
        public virtual void adapt()
        {
            widget.mainGrid.DataSource = null;
        }
        public virtual void showEditDialog()
        {
            //MessageBox.Show("Таблица не определина!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public virtual void insertDialog()
        {
            //MessageBox.Show("Таблица не определина", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void deleteRow()
        {
            if (widget.mainGrid.DataSource != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    DataRow row = widget.findCurrentRow(widget.mainGrid);
                    if (row != null)
                        row.Delete();
                    else
                        MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
             MessageBox.Show("Таблица не определина!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public virtual void dataSave()
        {
            //MessageBox.Show("Таблица не определина!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public virtual void dataRefresh()
        {
            //MessageBox.Show("Таблица не определина!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public TreeNode Node
        {
            get { return nodeData;  }
            set { nodeData = value; }
        }
    }

    public class PupilsTable : PlymorphicWidget
    {
        public PupilsTable(MainWindow window): base(window) { }

        protected override void view() 
        {
            widget.initViewRelation("relation1", "Национальность", 1, 15);
            widget.initViewRelation("relation2", "Класс", 1, 16);
            widget.initViewRelation("relation3", "Родители", 1, 17);

            widget.mainGrid.Columns[0].Visible = false;
            widget.mainGrid.Columns[1].Visible = false;
            //widget.mainGrid.Columns[2].Visible = false;
            widget.mainGrid.Columns[2].HeaderText = "Фамилия Имя Отчество";
            widget.mainGrid.Columns[2].Width = 230;
            widget.mainGrid.Columns[3].Visible = false;
            //widget.mainGrid.Columns[4].Visible = false;
            widget.mainGrid.Columns[4].HeaderText = "Дата рождения";
            widget.mainGrid.Columns[4].Width = 230;
            widget.mainGrid.Columns[5].Visible = false;
            widget.mainGrid.Columns[6].Visible = false;
            widget.mainGrid.Columns[7].Visible = false;
            widget.mainGrid.Columns[8].Visible = false;
            widget.mainGrid.Columns[9].Visible = false;
            widget.mainGrid.Columns[10].Visible = false;
            widget.mainGrid.Columns[11].Visible = false;
            widget.mainGrid.Columns[12].Visible = false;
            widget.mainGrid.Columns[13].Visible = false;
            widget.mainGrid.Columns[13].Visible = false;
            widget.mainGrid.Columns[14].Visible = false;
            widget.mainGrid.Columns[15].Visible = false;
            widget.mainGrid.Columns[16].Visible = false;
            widget.mainGrid.Columns[17].Visible = false;
        }
        public override void adaptFilterA() 
        {
            widget.pupilsParamDlg = new PupilsNameParam(widget.fbObject);
            if (widget.pupilsParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr = "P_NAME = " + "'" + widget.pupilsParamDlg.cbPupilsName.Text + "'";
                DataView view = new DataView(widget.fbObject.dataTable("PUPILS"), filterParemetr, "P_ID_PUPIL", DataViewRowState.CurrentRows);
                if (view.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view;
                    this.view();
                }
            }
        }
        public override void adaptFilterB()
        {
            widget.pupilsBirthdayParam = new PupilsBirthdayParam();
            if (widget.pupilsBirthdayParam.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr = "P_BIRTH_DATE >= " + "'" + widget.pupilsBirthdayParam.date1.Value.ToShortDateString() + "'" + " AND "+
                                        "P_BIRTH_DATE <= " + "'" + widget.pupilsBirthdayParam.date2.Value.ToShortDateString() + "'";
                DataView view = new DataView(widget.fbObject.dataTable("PUPILS"), filterParemetr, "P_ID_PUPIL", DataViewRowState.CurrentRows);
                if (view.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view;
                    this.view();
                }
            }
        }
        public override void adapt()
        {
            widget.mainGrid.DataSource = 0;
            DataView view = widget.pupilsView[widget.treePosition[nodeData.Text]];
            widget.currentTable = view.Table.TableName;
            widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
            widget.mainGrid.DataSource = view;
            this.view();
        }
        public override void showEditDialog()
        {
            widget.pplDlg = new PupilsDialog(widget.fbObject);
            DataRow row = widget.findCurrentRow(widget.mainGrid);
            if (row != null)
                widget.pplDlg.ShowDialog(row);
            else
                MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public override void insertDialog()
        {
            widget.pplDlg = new PupilsDialog(widget.fbObject);
            widget.pplDlg.ShowDialog();
        }
        public override void dataSave()
        {
            widget.fbObject.save("PUPILS");
        }
        public override void dataRefresh()
        {
            widget.fbObject.refill("PUPILS");
        }
    }

    public class SubjectTable  : PlymorphicWidget
    {
        public SubjectTable(MainWindow window) : base(window) { }

        protected override void view()
        {
            widget.initViewRelation("relation11", "Учитель", 1, 0);
            widget.initViewRelation("relation14", "Класс", 1, 1);

            widget.mainGrid.Columns[2].Visible = false;
            widget.mainGrid.Columns[3].Visible = false;
            widget.mainGrid.Columns[4].Visible = false;

            widget.mainGrid.Columns[5].HeaderText = "Название предмета";
            widget.mainGrid.Columns[5].Width = 230;
            widget.mainGrid.Columns[6].HeaderText = "Количество часов";
            widget.mainGrid.Columns[6].Width = 230;
        }
        public override void adaptFilterA() 
        {
            widget.teacherParamDlg = new TeacherNameParam(widget.fbObject);
            if (widget.teacherParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr1 = "T_NAME = " + "'" + widget.teacherParamDlg.cbTeacher.Text + "'";
                DataView view1 = new DataView(widget.fbObject.dataTable("TEACHERS"), filterParemetr1, "T_ID_TEACHER", DataViewRowState.CurrentRows);
                if (view1.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string filterParemetr2 = "S_ID_TEACHER = " + "'" + view1[0].Row[0].ToString() + "'";
                    DataView view2 = new DataView(widget.fbObject.dataTable("SUBJECT"), filterParemetr2, "S_ID_SUBJECT", DataViewRowState.CurrentRows);
                    if (view2.Count == 0)
                    {
                        MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view2.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view2;
                    //widget.mainStatusBar.Items.Add(widget.teacherParamDlg.cbTeacher.Text + " общее количество часов:");
                    this.view();
                }
            }
        }
        public override void adaptFilterB()
        {

        }
        public override void adapt()
        {
            widget.mainGrid.DataSource = 0;
            DataView view = widget.subjectView[widget.treePosition[nodeData.Parent.Text]];
            widget.currentTable = view.Table.TableName;
            widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
            widget.mainGrid.DataSource = view;
            this.view();

        }
        public override void showEditDialog()
        {
            widget.sbjDlg = new SubjectDialog(widget.fbObject);
            DataRow row = widget.findCurrentRow(widget.mainGrid);
            if (row != null)
                widget.sbjDlg.ShowDialog(row);
            else
                MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public override void insertDialog()
        {
            widget.sbjDlg = new SubjectDialog(widget.fbObject);
            widget.sbjDlg.ShowDialog();
        }
        public override void dataSave()
        {
            widget.fbObject.save("SUBJECT");
        }
        public override void dataRefresh()
        {
            widget.fbObject.refill("SUBJECT");
        }
    }

    public class ProgressTable : PlymorphicWidget
    {
        public ProgressTable(MainWindow window) : base(window) { }

        protected override void view()
        {
            widget.initViewRelation("relation13", "Ученик", 3, 0);
            widget.initViewRelation("relation5", "Предмет", 2, 0);

            widget.mainGrid.Columns[2].Visible = false;
            widget.mainGrid.Columns[3].Visible = false;
            widget.mainGrid.Columns[4].Visible = false;
            widget.mainGrid.Columns[8].Visible = false;

            widget.mainGrid.Columns[5].HeaderText = "1-й семестр";
            widget.mainGrid.Columns[5].Width = 140;
            widget.mainGrid.Columns[6].HeaderText = "2-й семестр";
            widget.mainGrid.Columns[6].Width = 140;
            widget.mainGrid.Columns[7].HeaderText = "Оценка за год";
            widget.mainGrid.Columns[7].Width = 140;
        }
        public override void adaptFilterA() 
        {
            widget.pupilsParamDlg = new PupilsNameParam(widget.fbObject);
            if (widget.pupilsParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr1 = "P_NAME = " + "'" + widget.pupilsParamDlg.cbPupilsName.Text + "'";
                DataView view1 = new DataView(widget.fbObject.dataTable("PUPILS"), filterParemetr1, "P_ID_PUPIL", DataViewRowState.CurrentRows);
                if (view1.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string filterParemetr2 = "P_ID_PUPIL = " + "'" + view1[0].Row[0].ToString() + "'";
                    DataView view2 = new DataView(widget.fbObject.dataTable("PROGRESS"), filterParemetr2, "P_ID_PROGRESS", DataViewRowState.CurrentRows);
                    if (view2.Count == 0)
                    {
                        MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view2.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view2;
                    this.view();
                }
            }
        }
        public override void adaptFilterB()
        {

        }
        public override void adapt()
        {
            widget.mainGrid.DataSource = 0;
            DataView view = widget.progresView[widget.treePosition[nodeData.Parent.Text]];
            widget.currentTable = view.Table.TableName;
            widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
            widget.mainGrid.DataSource = view;
            this.view();
        }
        public override void showEditDialog()
        {
            widget.prgDlg = new ProgressDialog(widget.fbObject);
            DataRow row = widget.findCurrentRow(widget.mainGrid);
            if (row != null)
                widget.prgDlg.ShowDialog(row);
            else
                MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public override void insertDialog()
        {
            widget.prgDlg = new ProgressDialog(widget.fbObject);
            widget.prgDlg.ShowDialog();
        }
        public override void dataSave()
        {
            widget.fbObject.save("PROGRESS");
        }
        public override void dataRefresh()
        {
            widget.fbObject.refill("PROGRESS");
        }
    }

    public class AbsenceTable  : PlymorphicWidget
    {
        public AbsenceTable(MainWindow window) : base(window) { }

        protected override void view() 
        {
            widget.initViewRelation("relation16", "Класс", 1, 0);
            widget.initViewRelation("relation6", "Ученик", 2, 0);

            widget.mainGrid.Columns[1].Visible = false;
            widget.mainGrid.Columns[2].Visible = false;
            widget.mainGrid.Columns[3].Visible = false;
            widget.mainGrid.Columns[6].Visible = false;

            widget.mainGrid.Columns[4].HeaderText = "Месяц";
            widget.mainGrid.Columns[4].Width = 140;
            widget.mainGrid.Columns[5].HeaderText = "Количество часов";
            widget.mainGrid.Columns[5].Width = 170;
        }
        public override void adaptFilterA() 
        {
            widget.pupilsParamDlg = new PupilsNameParam(widget.fbObject);
            if (widget.pupilsParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr1 = "P_NAME = " + "'" + widget.pupilsParamDlg.cbPupilsName.Text + "'";
                DataView view1 = new DataView(widget.fbObject.dataTable("PUPILS"), filterParemetr1, "P_ID_PUPIL", DataViewRowState.CurrentRows);
                if (view1.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string filterParemetr2 = "A_ID_PUPIL = " + "'" + view1[0].Row[0].ToString() + "'";
                    DataView view2 = new DataView(widget.fbObject.dataTable("ABSENCE"), filterParemetr2, "A_ID_ABSENCE", DataViewRowState.CurrentRows);
                    if (view2.Count == 0)
                    {
                        MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view2.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view2;
                    this.view();
                }
            }
        }
        public override void adaptFilterB()
        {

        }
        public override void adapt()
        {
            widget.mainGrid.DataSource = 0;
            DataView view = widget.absenceView[widget.treePosition[nodeData.Parent.Text]];
            widget.currentTable = view.Table.TableName;
            widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
            widget.mainGrid.DataSource = view;
            this.view();
        }
        public override void showEditDialog()
        {
            widget.absDlg = new AbsenceDialog(widget.fbObject);
            DataRow row = widget.findCurrentRow(widget.mainGrid);
            if (row != null)
                widget.absDlg.ShowDialog(row);
            else
                MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public override void insertDialog()
        {
            widget.absDlg = new AbsenceDialog(widget.fbObject);
            widget.absDlg.ShowDialog();
        }
        public override void dataSave()
        {
            widget.fbObject.save("ABSENCE");
        }
        public override void dataRefresh()
        {
            widget.fbObject.refill("ABSENCE"); 
        }
    }

    public class TeacherTable  : PlymorphicWidget
    {
        public TeacherTable(MainWindow window) : base(window) { }

        protected override void view() 
        {
            widget.initViewRelation("relation8", "Квалификация", 1, 17);
            widget.initViewRelation("relation9", "Образование", 1, 18);

            widget.mainGrid.Columns[0].Visible = false;
            //widget.mainGrid.Columns[1].Visible = false;
            widget.mainGrid.Columns[2].Visible = false;
            widget.mainGrid.Columns[3].Visible = false;
            widget.mainGrid.Columns[4].Visible = false;
            widget.mainGrid.Columns[5].Visible = false;
            widget.mainGrid.Columns[6].Visible = false;
            widget.mainGrid.Columns[7].Visible = false;
            widget.mainGrid.Columns[8].Visible = false;
            widget.mainGrid.Columns[9].Visible = false;
            widget.mainGrid.Columns[10].Visible = false;
            widget.mainGrid.Columns[11].Visible = false;
            widget.mainGrid.Columns[12].Visible = false;
            widget.mainGrid.Columns[13].Visible = false;
            widget.mainGrid.Columns[14].Visible = false;
            widget.mainGrid.Columns[15].Visible = false;
            widget.mainGrid.Columns[16].Visible = false;
            widget.mainGrid.Columns[18].Visible = false;

            widget.mainGrid.Columns[1].HeaderText = "Фамилия Имя Отчество";
            widget.mainGrid.Columns[1].Width = 230;
        }
        public override void adaptFilterA()
        {
            widget.teacherParamDlg = new TeacherNameParam(widget.fbObject);
            if (widget.teacherParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr = "T_NAME = " + "'" + widget.teacherParamDlg.cbTeacher.Text + "'";
                DataView view = new DataView(widget.fbObject.dataTable("TEACHERS"), filterParemetr, "T_ID_TEACHER", DataViewRowState.CurrentRows);
                if (view.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view;
                    this.view();
                    ///MessageBox.Show(view[0].Row[0].ToString());
                }
            }
        }
        public override void adaptFilterB()
        {
            widget.teacherCategoryParamDlg = new TeacherCategoryParam();
            if (widget.teacherCategoryParamDlg.ShowDialog() == DialogResult.OK)
            {
                string filterParemetr = "T_CATEGORY = " + "'" + widget.teacherCategoryParamDlg.cbTextParam.Text + "'";
                DataView view = new DataView(widget.fbObject.dataTable("TEACHERS"), filterParemetr, "T_ID_TEACHER", DataViewRowState.CurrentRows);
                if (view.Count == 0)
                    MessageBox.Show("Дані відсутні в базі", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    widget.mainGrid.DataSource = 0;
                    widget.currentTable = view.Table.TableName;
                    widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
                    widget.mainGrid.DataSource = view;
                    this.view();
                    ///MessageBox.Show(view[0].Row[0].ToString());
                }
            }
        }
        public override void adapt()
        {
            widget.mainGrid.DataSource = 0;
            widget.currentTable = "TEACHERS";
            widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
            widget.mainGrid.DataSource = widget.bindingSource1;
            this.view();

        }
        public override void showEditDialog()
        {
            widget.tchDlg = new TeachersDialog(widget.fbObject);
            DataRow row = widget.findCurrentRow(widget.mainGrid);
            if (row != null)
                widget.tchDlg.ShowDialog(row);
            else
                MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public override void insertDialog()
        {
            widget.tchDlg = new TeachersDialog(widget.fbObject);
            widget.tchDlg.ShowDialog();
        }
        public override void dataSave()
        {
            widget.fbObject.save("TEACHERS");
        }
        public override void dataRefresh()
        {
            widget.fbObject.refill("TEACHERS"); 
        }
    }

    public class ElectiveTable : PlymorphicWidget
    {
        public ElectiveTable(MainWindow window) : base(window) { }

        protected override void view() 
        {
            widget.initViewRelation("relation7", "Ученик", 2, 4);
            widget.initViewRelation("relation12", "Учитель", 1, 5);

            widget.mainGrid.Columns[0].Visible = false;
            widget.mainGrid.Columns[2].Visible = false;
            widget.mainGrid.Columns[3].Visible = false;

            widget.mainGrid.Columns[1].HeaderText = "Факультатив";
            widget.mainGrid.Columns[1].Width = 230;
            widget.mainGrid.Columns[6].HeaderText = "Количество часов";
            widget.mainGrid.Columns[6].Width = 230;
        }
        public override void adaptFilterA() 
        {
        
        }
        public override void adaptFilterB()
        {

        }
        public override void adapt()
        {
            widget.mainGrid.DataSource = 0;
            widget.currentTable = "ELECTIVE";
            widget.bindingSource1.DataSource = widget.fbObject.dataTable(widget.currentTable);
            widget.mainGrid.DataSource = widget.bindingSource1;
            this.view();
        }
        public override void showEditDialog()
        {
            widget.elcDlg = new ElectiveDialog(widget.fbObject);
            DataRow row = widget.findCurrentRow(widget.mainGrid);
            if (row != null)
                widget.elcDlg.ShowDialog(row);
            else
                MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public override void insertDialog()
        {
            widget.elcDlg = new ElectiveDialog(widget.fbObject);
            widget.elcDlg.ShowDialog();
        }
        public override void dataSave()
        {
            widget.fbObject.save("ELECTIVE"); 
        }
        public override void dataRefresh()
        {
            widget.fbObject.refill("ELECTIVE"); 
        }
    }

    public class WidgetAgregat
    { 
        private PlymorphicWidget[] plymorphWidget;
        private const int size = 7;
        public WidgetAgregat(MainWindow window)
        { 
            plymorphWidget    = new PlymorphicWidget[size];
            plymorphWidget[0] = new PlymorphicWidget(window);
            plymorphWidget[1] = new PupilsTable(window);
            plymorphWidget[2] = new SubjectTable(window);
            plymorphWidget[3] = new ProgressTable(window);
            plymorphWidget[4] = new AbsenceTable(window);
            plymorphWidget[5] = new TeacherTable(window);
            plymorphWidget[6] = new ElectiveTable(window);
        }
        public PlymorphicWidget this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    return plymorphWidget[0];
                return plymorphWidget[index];
            } 
        }
    }
}
