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
    public partial class EducationDialog : Form
    {
         private FirebirdInterface fb;
        public EducationDialog()
      
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(FirebirdInterface fbObject)
        {
            fb = fbObject;
            bindingSource_ed.DataSource = fb.dataTable("EDUCATION");
            dataGridView_ed.DataSource = bindingSource_ed;
            dataGridView_ed.Columns[0].Visible = false;
            dataGridView_ed.Columns[1].HeaderText = "Назва навчального закладу";
            dataGridView_ed.Columns[2].HeaderText = "Адреса";
            bindingNavigator_ed.BindingSource = bindingSource_ed;
            //dataGridView_ed.DataSource = bindingSource_ed;

            return base.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        
        {
            this.Validate();
            bindingSource_ed.EndEdit();
            if (!fb.save("EDUCATION"))
            {
                MessageBox.Show("Збереження не виконано або не було оновлень БД");
            }
        }
        

    }
}
