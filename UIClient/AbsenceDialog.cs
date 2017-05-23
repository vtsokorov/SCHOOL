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
    public partial class AbsenceDialog : Form
    {
        private FirebirdInterface fbObject;
        private DataTable table;
        private DataRow currentRow;
        private bool isNewRow;

        private int SelectedIndexInDataTable;

        private void IniDataBindingDialog(DataRow row)
        {
            SelectedIndexInDataTable = table.Rows.IndexOf(row);
            this.BindingContext[fbObject.dataSet(), "ABSENCE"].Position = SelectedIndexInDataTable;

            tbManth.DataBindings.Add("Text", fbObject.dataSet(), "ABSENCE.A_MANTH");
            tbHours.DataBindings.Add("Text", fbObject.dataSet(), "ABSENCE.A_HOURS");
            cbPupil.SelectedValue = Int32.Parse(row["A_ID_PUPIL"].ToString());
            cbClass.SelectedValue = Int32.Parse(row["A_ID_CLASS"].ToString());
          
                 }

        private void clearViewRelation()
        {
            cbPupil.SelectedValue = -1;
            cbClass.SelectedValue = -1;   
        }

        public AbsenceDialog(FirebirdInterface fb)
        {
            InitializeComponent();
            fbObject = fb;
            table = fbObject.dataTable("ABSENCE");

            cbPupil.BindingContext = new BindingContext();
            cbPupil.DataSource = fbObject.dataTable("PUPILS");
            cbPupil.DisplayMember = "P_NAME";
            cbPupil.ValueMember = "P_ID_PUPIL";

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
            currentRow = fbObject.dataTable("ABSENCE").NewRow();
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
    }
}
