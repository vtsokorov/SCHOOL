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
    public partial class SubjectDialog : Form
    {
        private FirebirdInterface fbObject;
        private DataTable table;
        private DataRow currentRow;
        private bool isNewRow;

        private int SelectedIndexInDataTable;

        private void IniDataBindingDialog(DataRow row)
        {
            SelectedIndexInDataTable = table.Rows.IndexOf(row);
            this.BindingContext[fbObject.dataSet(), "SUBJECT"].Position = SelectedIndexInDataTable;

            tbName.DataBindings.Add("Text", fbObject.dataSet(), "SUBJECT.S_NAME");
            tbHours.DataBindings.Add("Text", fbObject.dataSet(), "SUBJECT.S_HOURS");
            cbTeacher.SelectedValue = Int32.Parse(row["S_ID_TEACHER"].ToString());
            cbClass.SelectedValue = Int32.Parse(row["S_ID_CLASS"].ToString());
                 }

        private void clearViewRelation()
        {
            cbTeacher.SelectedValue = -1;
            cbClass.SelectedValue = -1;
                   }

        public SubjectDialog(FirebirdInterface fb)
        {
            InitializeComponent();
            fbObject = fb;
            table = fbObject.dataTable("SUBJECT");

            cbTeacher.BindingContext = new BindingContext();
            cbTeacher.DataSource = fbObject.dataTable("TEACHERS");
            cbTeacher.DisplayMember = "T_NAME";
            cbTeacher.ValueMember = "T_ID_TEACHER";

            cbClass.BindingContext = new BindingContext();
            cbClass.DataSource = fbObject.dataTable("CLASS");
            cbClass.DisplayMember = "C_CLASSNANE";
            cbClass.ValueMember = "C_ID_CLASS";

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
            currentRow = fbObject.dataTable("SUBJECT").NewRow();
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

            currentRow["S_NAME"] = tbName.Text;
            currentRow["S_HOURS"] = tbHours.Text;
            currentRow["S_ID_TEACHER"] = Convert.ToInt32(cbTeacher.SelectedValue);
            currentRow["S_ID_CLASS"] = Convert.ToInt32(cbClass.SelectedValue);

            if (isNewRow)
                fbObject.dataTable("SUBJECT").Rows.Add(currentRow);
            else
                currentRow.EndEdit();

            fbObject.save("SUBJECT");

            Close();
        }
    }
}
