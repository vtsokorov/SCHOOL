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
    public partial class FamilyDialog : Form
    {
        private FirebirdInterface fb;
        public FamilyDialog()
      
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(FirebirdInterface fbObject)
        {
            fb = fbObject;
            bindingSource_fam.DataSource = fb.dataTable("FAMILY");
            dataGridView_fam.DataSource = bindingSource_fam;
            dataGridView_fam.Columns[0].Visible = false;
            dataGridView_fam.Columns[1].HeaderText = "ПІБ батьків";
            dataGridView_fam.Columns[2].HeaderText = "Кількість дітей у сім'ї";
            dataGridView_fam.Columns[3].HeaderText = "Місце роботи батька";
            dataGridView_fam.Columns[4].HeaderText = "Місце роботи мати";
            bindingNavigator_fam.BindingSource = bindingSource_fam;
            return base.ShowDialog();
        }

        

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            bindingSource_fam.EndEdit();
            if (!fb.save("FAMILY"))
            {
                MessageBox.Show("Збереження не виконано або не було оновлень БД");
            }
        }
        
    }
}
