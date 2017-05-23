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
    public partial class ProgressDialog : Form
    {
        private FirebirdInterface fbObject;
        private DataTable table;
        private DataRow currentRow;
        private bool isNewRow;

        private int SelectedIndexInDataTable;

        private void IniDataBindingDialog(DataRow row)
        {
            SelectedIndexInDataTable = table.Rows.IndexOf(row);
            this.BindingContext[fbObject.dataSet(), "PROGRESS"].Position = SelectedIndexInDataTable;

            tbFsem.DataBindings.Add("Text", fbObject.dataSet(), "PROGRESS.P_FIRST_SEMESTER_MARK");
            tbSsem.DataBindings.Add("Text", fbObject.dataSet(), "PROGRESS.P_SECOND_SEMESTER_MARK");
            tbYear.DataBindings.Add("Text", fbObject.dataSet(), "PROGRESS.P_YEAR_MARK");
            cbPupil.SelectedValue = Int32.Parse(row["P_ID_PUPIL"].ToString());
            cbClass.SelectedValue = Int32.Parse(row["P_ID_CLASS"].ToString());
            cbSubject.SelectedValue = Int32.Parse(row["P_ID_SUBJECT"].ToString());
       }

        private void clearViewRelation()
        {
            cbPupil.SelectedValue = -1;
            cbClass.SelectedValue = -1;
            cbSubject.SelectedValue = -1;
        }

        public ProgressDialog(FirebirdInterface fb)
        {
            InitializeComponent();
            fbObject = fb;
            table = fbObject.dataTable("PROGRESS");

            cbPupil.BindingContext = new BindingContext();
            cbPupil.DataSource = fbObject.dataTable("PUPILS");
            cbPupil.DisplayMember = "P_NAME";
            cbPupil.ValueMember = "P_ID_PUPIL";

            cbClass.BindingContext = new BindingContext();
            cbClass.DataSource = fbObject.dataTable("CLASS");
            cbClass.DisplayMember = "C_CLASSNANE";
            cbClass.ValueMember = "C_ID_CLASS";

            cbSubject.BindingContext = new BindingContext();
            cbSubject.DataSource = fbObject.dataTable("SUBJECT");
            cbSubject.DisplayMember = "S_NAME";
            cbSubject.ValueMember = "S_ID_SUBJECT";

            isNewRow = false;
        }

        public DialogResult ShowDialog(DataRow row)
        {
            currentRow = row;
            IniDataBindingDialog(currentRow);
            isNewRow = false;
            return base.ShowDialog();
        }

        public new DialogResult ShowDialog()
        {
            clearViewRelation();
            currentRow = fbObject.dataTable("PROGRESS").NewRow();
            isNewRow = true;
            return base.ShowDialog();
        }

        private void saveClick_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label14_Click(object sender, EventArgs e)
        {
        
        }

        private void dateBirthday_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void saveClic_Click(object sender, EventArgs e)
        {
            if (!isNewRow)
                currentRow.BeginEdit();

            currentRow["P_FIRST_SEMESTER_MARK"] = tbFsem.Text;
            currentRow["P_SECOND_SEMESTER_MARK"] = tbSsem.Text;
            currentRow["P_YEAR_MARK"] = tbYear.Text;
            currentRow["P_ID_PUPIL"] = Convert.ToInt32(cbPupil.SelectedValue);
            currentRow["P_ID_SUBJECT"] = Convert.ToInt32(cbSubject.SelectedValue);
            currentRow["P_ID_CLASS"] = Convert.ToInt32(cbClass.SelectedValue);

            if (isNewRow)
                fbObject.dataTable("PROGRESS").Rows.Add(currentRow);
            else
                currentRow.EndEdit();

            fbObject.save("PROGRESS");

            Close();
        }
    }
}
