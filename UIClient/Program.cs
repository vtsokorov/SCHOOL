using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace UIClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true) {
                LoginDialog dlg = new LoginDialog();
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK) {
                    FirebirdInterface fb = dlg.FirebirdObject();
                    Thread t = new Thread(new ThreadStart(fb.loadTables));
                    t.Start(); t.Join();
                    if (!t.IsAlive) {
                        MainWindow mainForm = new MainWindow(fb);
                        Application.Run(mainForm);
                        if (mainForm.IsRun == false) break;
                    }
                }
                else if (result != DialogResult.Retry) break;
            }
        }
    }
}
