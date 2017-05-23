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
    public partial class PupilsDialog : Form
    {
        private FirebirdInterface fbObject;
        private DataTable table;
        private DataRow currentRow;
        private bool isNewRow;

        private int SelectedIndexInDataTable;

        private void IniDataBindingDialog(DataRow row)
        {
            SelectedIndexInDataTable = table.Rows.IndexOf(row);
            this.BindingContext[fbObject.dataSet(), "PUPILS"].Position = SelectedIndexInDataTable;

            tbName.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_NAME");
            dateBirthday.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_BIRTH_DATE");
            dateBegin.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_BEGINNING_DATE");
            dateEnd.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_ENDING_DATE");

            tbCaseNumber.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_CASE_NUMBER");
            tbAddress.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_ADDRESS");

            tbDocType.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_DOCUMENT_TYPE");
            tbDocSeries.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_DOC_SERIES");
            tbDocNumber.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_DOC_NUMBER");

            cbSex.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_SEX");
            cbIndividual.DataBindings.Add("Text", fbObject.dataSet(), "PUPILS.P_INDIVIDUAL");

            cbNationality.SelectedValue = Int32.Parse(row["P_ID_NATIONALITY"].ToString());
            cbClass.SelectedValue = Int32.Parse(row["P_ID_CLASS"].ToString());
            cbFamily.SelectedValue = Int32.Parse(row["P_ID_FAMILY"].ToString());
        }

        private void clearViewRelation()
        {
            cbNationality.SelectedValue = -1;
            cbClass.SelectedValue       = -1;
            cbFamily.SelectedValue      = -1;
        }

        public PupilsDialog(FirebirdInterface fb)
        {
            InitializeComponent();
            fbObject = fb;
            table = fbObject.dataTable("PUPILS");
            
            cbNationality.BindingContext = new BindingContext();
            cbNationality.DataSource     = fbObject.dataTable("NATIONALITY");
            cbNationality.DisplayMember  = "N_NATION";
            cbNationality.ValueMember    = "N_ID_NATIONALITY";

            cbClass.BindingContext = new BindingContext();
            cbClass.DataSource = fbObject.dataTable("CLASS");
            cbClass.DisplayMember = "C_CLASSNANE";
            cbClass.ValueMember   = "C_ID_CLASS";

            cbFamily.BindingContext = new BindingContext();
            cbFamily.DataSource = fbObject.dataTable("FAMILY");
            cbFamily.DisplayMember = "F_PARENTS";
            cbFamily.ValueMember = "F_ID_FAMILY";
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
            currentRow = fbObject.dataTable("PUPILS").NewRow();
            isNewRow = true;
            return base.ShowDialog();
        }

        private void saveClick_Click(object sender, EventArgs e)
        {
            if (!isNewRow) 
                currentRow.BeginEdit();

            currentRow["P_CASE_NUMBER"]     = tbCaseNumber.Text;
            currentRow["P_NAME"]            = tbName.Text;
            currentRow["P_SEX"]             = cbSex.Text;
            currentRow["P_BIRTH_DATE"]      = dateBirthday.Value;
            currentRow["P_ADDRESS"]         = tbAddress.Text;
            currentRow["P_ID_NATIONALITY"]  = Convert.ToInt32(cbNationality.SelectedValue);
            currentRow["P_DOCUMENT_TYPE"]   = tbDocType.Text;
            currentRow["P_DOC_SERIES"]      = tbDocSeries.Text;
            currentRow["P_DOC_NUMBER"]      = tbDocNumber.Text;
            currentRow["P_ID_FAMILY"]       = Convert.ToInt32(cbFamily.SelectedValue);
            currentRow["P_ID_CLASS"]        = Convert.ToInt32(cbClass.SelectedValue);
            currentRow["P_INDIVIDUAL"]      = cbIndividual.Text;
            currentRow["P_BEGINNING_DATE"]  = dateBegin.Value;
            currentRow["P_ENDING_DATE"]     = dateEnd.Value;

            if (isNewRow) 
                fbObject.dataTable("PUPILS").Rows.Add(currentRow);
            else
                currentRow.EndEdit();

            fbObject.save("PUPILS");

            Close();
        }

        private void addNationality_Click(object sender, EventArgs e)
        {
            NationalityDialog dlg = new NationalityDialog();
            dlg.ShowDialog(fbObject);
        }

        private void addFamily_Click(object sender, EventArgs e)
        {
            FamilyDialog dialog = new FamilyDialog();
            dialog.ShowDialog(fbObject);
        }

    }
}


//DataRowView currow = (DataRowView)BindingSource.Current;
//int id = Convert.ToInt32(currow["columnname_int"]);
//string name=currow["columnname_string"].ToString(); 
