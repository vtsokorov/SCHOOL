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
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        public new DialogResult ShowDialog()
        {
            libPath.Text   = SettingsIni.IniReadValue("MAIN", "CLIENT_LIBRARY_PATH");
            string address = SettingsIni.IniReadValue("MAIN", "SERVER_NAME");
            if (address != string.Empty) {
                serverName.Items.Add(address);
                serverName.SelectedIndex = serverName.Items.Count - 1;
                serverName.Visible = true;
                label2.Visible = true;
                serverType.SelectedIndex = 1;
            }
            else serverType.SelectedIndex = 0;

            dbPath.Text = SettingsIni.IniReadValue("MAIN", "DATABASE_PATH");
            string portNumber = SettingsIni.IniReadValue("MAIN", "PORT");
            port.Value = portNumber == string.Empty ? 0 : Int32.Parse(portNumber);
            string users = SettingsIni.IniReadValue("MAIN", "USER");
            if (users != string.Empty) {
                userList.Items.AddRange(users.Split(','));
                userList.SelectedIndex = userList.Items.Count - 1;
            }
            role.Text = SettingsIni.IniReadValue("MAIN", "ROLE");
            charsetList.SelectedItem = SettingsIni.IniReadValue("MAIN", "CHARSET");

            
            return base.ShowDialog();
        }

        private void selectServerType(object sender, EventArgs e)
        {
            if (serverType.SelectedIndex == 1)
            {
                label2.Visible = true;
                serverName.Visible = true;
            }
            if (serverType.SelectedIndex == 0)
            {
                label2.Visible = false;
                serverName.Visible = false;
            }
        }

        private void WrittenSettings_Click(object sender, EventArgs e)
        {
            SettingsIni.IniWriteValue("MAIN", "CLIENT_LIBRARY_PATH", libPath.Text);
            SettingsIni.IniWriteValue("MAIN", "DATABASE_PATH", dbPath.Text);

            SettingsIni.IniWriteValue("MAIN", "CLIENT_LIBRARY_PATH", libPath.Text);
            SettingsIni.IniWriteValue("MAIN", "SERVER_NAME", serverType.SelectedIndex == 0 ? string.Empty : serverName.Text);
            SettingsIni.IniWriteValue("MAIN", "DATABASE_PATH", dbPath.Text);
            SettingsIni.IniWriteValue("MAIN", "PORT", port.Value.ToString());

            StringBuilder users = new StringBuilder();
            for (int i = 0; i < userList.Items.Count; ++i)
                users.AppendFormat(i != (userList.Items.Count - 1) ? "{0}," : "{0}", userList.Items[i].ToString());

            SettingsIni.IniWriteValue("MAIN", "USER", users.ToString());
            SettingsIni.IniWriteValue("MAIN", "ROLE", role.Text);
            SettingsIni.IniWriteValue("MAIN", "CHARSET", charsetList.Text);

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            if (userList.Text != string.Empty)
                userList.Items.Add(userList.Text);
        }

        private void delUser_Click(object sender, EventArgs e)
        {
            int index = userList.SelectedIndex;
            if (index >= 0)
            {
                userList.Items.RemoveAt(index);
                userList.Text = string.Empty;
            }
        }

    }
}
