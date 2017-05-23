using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIClient
{
    public partial class LoginDialog : Form
    {
        private DialogResult result        = new DialogResult();
        private SettingsDialog settingsDlg = new SettingsDialog();
        private FirebirdInterface fbOject  = new FirebirdInterface();

        public FirebirdInterface FirebirdObject()
        {
            return fbOject;
        }

        public LoginDialog()
        {
            InitializeComponent();
            password.Text = "masterkey";
        }

        private bool isExistFile()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\settings.ini"))
                return true;
            else {
                MessageBox.Show("Файл настроек не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Accept.Enabled = false;
                Settings.Enabled = false;
                return false;
            }

        }

        public new DialogResult ShowDialog()
        {
            if (isExistFile())
            {
                ConnectItems.library = SettingsIni.IniReadValue("MAIN", "CLIENT_LIBRARY_PATH");
                ConnectItems.server = SettingsIni.IniReadValue("MAIN", "SERVER_NAME");

                ConnectItems.database = SettingsIni.IniReadValue("MAIN", "DATABASE_PATH");
                string portNumber = SettingsIni.IniReadValue("MAIN", "PORT");
                ConnectItems.port = portNumber == string.Empty ? 0 : Int32.Parse(portNumber);
                string users = SettingsIni.IniReadValue("MAIN", "USER");
                if (users != string.Empty)
                {
                    ConnectItems.users = users.Split(',');
                    userList.Items.AddRange(ConnectItems.users);
                    userList.SelectedIndex = userList.Items.Count - 1;
                }
                ConnectItems.role = SettingsIni.IniReadValue("MAIN", "ROLE");
                ConnectItems.charset = SettingsIni.IniReadValue("MAIN", "CHARSET");
            }

            return base.ShowDialog() == DialogResult.OK
                && result == DialogResult.OK ? DialogResult.OK : 
                result == DialogResult.Retry ? DialogResult.Retry : DialogResult.Cancel;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
             fbOject.initConnectString(ConnectItems.library, 
                                      ConnectItems.database, 
                                      ConnectItems.users[userList.SelectedIndex], 
                                      password.Text, 
                                      ConnectItems.role, 
                                      ConnectItems.charset, 
                                      ConnectItems.port);
             if (!fbOject.openDataBase())
                 result = DialogResult.Retry;
             else 
                 result = DialogResult.OK;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settingsDlg.ShowDialog();
        }
    }
}
