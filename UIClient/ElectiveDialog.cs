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
    public partial class ElectiveDialog : Form
    {
         private FirebirdInterface fbObject;
        private DataTable table;
        private DataRow currentRow;
        private bool isNewRow;

        private int SelectedIndexInDataTable;

        private void IniDataBindingDialog(DataRow row)
        {
            SelectedIndexInDataTable = table.Rows.IndexOf(row);
            this.BindingContext[fbObject.dataSet(), "ELECTIVE"].Position = SelectedIndexInDataTable;

            tbName.DataBindings.Add("Text", fbObject.dataSet(), "ELECTIVE.E_NAME");
            tbHours.DataBindings.Add("Text", fbObject.dataSet(), "ELECTIVE.E_HOURS");
            cbPupil.SelectedValue = Int32.Parse(row["E_ID_PUPIL"].ToString());
            cbTeacher.SelectedValue = Int32.Parse(row["E_ID_TEACHER"].ToString());
          
                 }

        private void clearViewRelation()
        {
            cbPupil.SelectedValue = -1;
            cbTeacher.SelectedValue = -1;
           
                   }

        public ElectiveDialog (FirebirdInterface fb)
        {
            InitializeComponent();
            fbObject = fb;
            table = fbObject.dataTable("ELECTIVE");

            cbPupil.BindingContext = new BindingContext();
            cbPupil.DataSource = fbObject.dataTable("PUPILS");
            cbPupil.DisplayMember = "P_NAME";
            cbPupil.ValueMember = "P_ID_PUPIL";

            cbTeacher.BindingContext = new BindingContext();
            cbTeacher.DataSource = fbObject.dataTable("TEACHERS");
            cbTeacher.DisplayMember = "T_NAME";
            cbTeacher.ValueMember = "T_ID_TEACHER";

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
            currentRow = fbObject.dataTable("ELECTIVE").NewRow();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isNewRow)
                currentRow.BeginEdit();

            currentRow["E_NAME"] = tbName.Text;
            currentRow["E_HOURS"] = tbHours.Text;
            currentRow["E_ID_PUPIL"] = Convert.ToInt32(cbPupil.SelectedValue);
            currentRow["E_ID_TEACHER"] = Convert.ToInt32(cbTeacher.SelectedValue);

            if (isNewRow)
                fbObject.dataTable("ELECTIVE").Rows.Add(currentRow);
            else
                currentRow.EndEdit();

            fbObject.save("ELECTIVE");

            Close();
        }
    }
}
