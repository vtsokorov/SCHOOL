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
    public partial class QualificationDialog : Form
    {
          private FirebirdInterface fb;
          public QualificationDialog()
      
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(FirebirdInterface fbObject)
        {
            fb = fbObject;
            bindingSource_qlf.DataSource = fb.dataTable("QUALIFICATION");
            dataGridView_qlf.DataSource = bindingSource_qlf;
            dataGridView_qlf.Columns[0].Visible = false;
            dataGridView_qlf.Columns[1].HeaderText = "Квіліфікація";
            bindingNavigator_qlf.BindingSource = bindingSource_qlf;

            return base.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            bindingSource_qlf.EndEdit();
            if (!fb.save("QUALIFICATION"))
            {
                MessageBox.Show("Збереження не виконано або не було оновлень БД");
            }
        }

            

      
        
    }
}
