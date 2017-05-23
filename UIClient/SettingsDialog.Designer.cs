namespace UIClient
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.libPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.TextBox();
            this.userList = new System.Windows.Forms.ComboBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.addUser = new System.Windows.Forms.Button();
            this.delUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dbPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.serverType = new System.Windows.Forms.ComboBox();
            this.serverName = new System.Windows.Forms.ComboBox();
            this.charsetList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.WrittenSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Укажите параметры соединения с БД";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.75791F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.libPath, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 246);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(540, 39);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(534, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Файл клиентской библиотеки";
            // 
            // libPath
            // 
            this.libPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libPath.Location = new System.Drawing.Point(3, 15);
            this.libPath.Name = "libPath";
            this.libPath.Size = new System.Drawing.Size(534, 20);
            this.libPath.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.70428F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.06226F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.password, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.role, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.userList, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.port, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.addUser, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.delUser, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 122);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(540, 115);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пользователь";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(47, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Пароль";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(60, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Роль";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(60, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Порт";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.password.Location = new System.Drawing.Point(98, 33);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(329, 20);
            this.password.TabIndex = 5;
            // 
            // role
            // 
            this.role.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.role.Location = new System.Drawing.Point(98, 61);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(329, 20);
            this.role.TabIndex = 6;
            // 
            // userList
            // 
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(98, 3);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(329, 21);
            this.userList.TabIndex = 7;
            // 
            // port
            // 
            this.port.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.port.Location = new System.Drawing.Point(98, 92);
            this.port.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(329, 20);
            this.port.TabIndex = 8;
            this.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addUser
            // 
            this.addUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser.Location = new System.Drawing.Point(433, 3);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(48, 22);
            this.addUser.TabIndex = 9;
            this.addUser.Text = "+";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // delUser
            // 
            this.delUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delUser.Location = new System.Drawing.Point(487, 3);
            this.delUser.Name = "delUser";
            this.delUser.Size = new System.Drawing.Size(50, 22);
            this.delUser.TabIndex = 10;
            this.delUser.Text = "-";
            this.delUser.UseVisualStyleBackColor = true;
            this.delUser.Click += new System.EventHandler(this.delUser_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.44444F));
            this.tableLayoutPanel3.Controls.Add(this.dbPath, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 79);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dbPath
            // 
            this.dbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbPath.Location = new System.Drawing.Point(3, 16);
            this.dbPath.Name = "dbPath";
            this.dbPath.Size = new System.Drawing.Size(534, 20);
            this.dbPath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Файл базы данных";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.serverType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.serverName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.charsetList, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // serverType
            // 
            this.serverType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverType.FormattingEnabled = true;
            this.serverType.Items.AddRange(new object[] {
            "Локальный",
            "Удаленный"});
            this.serverType.Location = new System.Drawing.Point(3, 26);
            this.serverType.Name = "serverType";
            this.serverType.Size = new System.Drawing.Size(173, 21);
            this.serverType.TabIndex = 0;
            this.serverType.SelectedIndexChanged += new System.EventHandler(this.selectServerType);
            // 
            // serverName
            // 
            this.serverName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverName.FormattingEnabled = true;
            this.serverName.Location = new System.Drawing.Point(182, 26);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(174, 21);
            this.serverName.TabIndex = 1;
            this.serverName.Visible = false;
            // 
            // charsetList
            // 
            this.charsetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charsetList.FormattingEnabled = true;
            this.charsetList.Items.AddRange(new object[] {
            "ASCII",
            "BIG_5",
            "CP943C",
            "CYRL",
            "DOS437",
            "DOS850",
            "DOS852",
            "DOS857",
            "DOS860",
            "DOS861",
            "DOS863",
            "DOS865",
            "EUCJ_0208",
            "GB_2312",
            "GBK",
            "ISO8859_1",
            "ISO8859_2",
            "KSC_5601",
            "NEXT",
            "NONE",
            "OCTETS",
            "SJIS_0208",
            "TIS620",
            "UNICODE_FSS",
            "UTF8",
            "WIN1250",
            "WIN1251",
            "WIN1252",
            "WIN1253",
            "WIN1254"});
            this.charsetList.Location = new System.Drawing.Point(362, 26);
            this.charsetList.Name = "charsetList";
            this.charsetList.Size = new System.Drawing.Size(175, 21);
            this.charsetList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(182, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя сервера";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(362, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кодировка";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.Location = new System.Drawing.Point(141, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(136, 26);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // WrittenSettings
            // 
            this.WrittenSettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.WrittenSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.WrittenSettings.Location = new System.Drawing.Point(0, 0);
            this.WrittenSettings.Name = "WrittenSettings";
            this.WrittenSettings.Size = new System.Drawing.Size(135, 26);
            this.WrittenSettings.TabIndex = 4;
            this.WrittenSettings.Text = "Записать настройки";
            this.WrittenSettings.UseVisualStyleBackColor = true;
            this.WrittenSettings.Click += new System.EventHandler(this.WrittenSettings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WrittenSettings);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Location = new System.Drawing.Point(297, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 26);
            this.panel1.TabIndex = 5;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox libPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.ComboBox userList;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button delUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox dbPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox serverType;
        private System.Windows.Forms.ComboBox charsetList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button WrittenSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox serverName;

    }
}