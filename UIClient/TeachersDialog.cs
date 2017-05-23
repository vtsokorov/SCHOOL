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
    public partial class TeachersDialog : Form
    {
        private FirebirdInterface fbObject;
        private DataTable table;
        private DataRow currentRow;
        private bool isNewRow;

        private int SelectedIndexInDataTable;

        private void IniDataBindingDialog(DataRow row)
        {
            SelectedIndexInDataTable = table.Rows.IndexOf(row);
            this.BindingContext[fbObject.dataSet(), "TEACHERS"].Position = SelectedIndexInDataTable;

            tbName.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_NAME");
            dateBirthday.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_BIRTH_DATE");
            dateBegin.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_START_OF_WORK");
            dateEnd.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_END_OF_WORK");

            tbIdenNamber.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_IDENTIFICATION_CODE");
            tbAddress.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_ADDRESS");

            tbDocSer.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_DOC_SERIES");
            tbDocNom.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_DOC_NUMBER");
            tbDocKem.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_DOC_ISSUE");

            tbDiplomSer.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_DEGREE_SERIES");
            tbDiplomNom.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_DEGREE_NUMBER");
            cbVuz.SelectedValue = Int32.Parse(row["T_ID_EDUCATION"].ToString());


            tbPosada.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_POSITION");
            cbQualif.SelectedValue = Int32.Parse(row["T_ID_QUALIFICATION"].ToString());

            cbSex.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_SEX");
            tbKategory.DataBindings.Add("Text", fbObject.dataSet(), "TEACHERS.T_CATEGORY");
                 
             }

        private void clearViewRelation()
        {
            cbQualif.SelectedValue = -1;
            cbVuz.SelectedValue = -1;
                   }

        public TeachersDialog (FirebirdInterface fb)
        {
            InitializeComponent();
            fbObject = fb;
            table = fbObject.dataTable("TEACHERS");

            cbQualif.BindingContext = new BindingContext();
            cbQualif.DataSource = fbObject.dataTable("QUALIFICATION");
            cbQualif.DisplayMember = "Q_NAME";
            cbQualif.ValueMember = "Q_ID_QUALIFICATION";

            cbVuz.BindingContext = new BindingContext();
            cbVuz.DataSource = fbObject.dataTable("EDUCATION");
            cbVuz.DisplayMember = "E_NAME";
            cbVuz.ValueMember = "E_ID_EDUCATION";

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
            currentRow = fbObject.dataTable("TEACHERS").NewRow();
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
