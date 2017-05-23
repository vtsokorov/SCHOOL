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
    public partial class PupilsNameParam : Form
    {
        public PupilsNameParam(FirebirdInterface fb)
        {
            InitializeComponent();

            cbPupilsName.BindingContext = new BindingContext();
            cbPupilsName.DataSource = fb.dataTable("PUPILS");
            cbPupilsName.DisplayMember = "P_NAME";
            cbPupilsName.SelectedIndex = -1;
        }
    }
}
