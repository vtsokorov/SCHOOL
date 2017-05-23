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
    public partial class TeacherNameParam : Form
    {
        public TeacherNameParam(FirebirdInterface fb)
        {
            InitializeComponent();

            cbTeacher.BindingContext = new BindingContext();
            cbTeacher.DataSource = fb.dataTable("TEACHERS");
            cbTeacher.DisplayMember = "T_NAME";
            cbTeacher.SelectedIndex = -1;
        }
    }
}
