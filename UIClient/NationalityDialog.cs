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
    public partial class NationalityDialog : Form
    {
        private FirebirdInterface fb;
        private DataTable table;
        private int SelectIndex;

        public NationalityDialog()
        {
            InitializeComponent();
            SelectIndex = 0;
        }

        public DialogResult ShowDialog(FirebirdInterface fbObject)
        {
            fb    = fbObject;
            table = fb.dataTable("NATIONALITY");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Национальность";
            return base.ShowDialog();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (!fb.isOpen()) fb.openDataBase();

            fb.save("NATIONALITY");

            fb.closeDataBase();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!fb.isOpen()) fb.openDataBase();

            table.Rows[dataGridView1.SelectedRows[0].Index].Delete();
            
            fb.save("NATIONALITY");

            fb.closeDataBase();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!fb.isOpen()) fb.openDataBase();
   
            fb.save("NATIONALITY");

            fb.closeDataBase();
        }

        private void selectrow(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectIndex = e.RowIndex;
        }


        private void KeyDownEnter(object sender, KeyEventArgs e)
        {

        }
    }
}
