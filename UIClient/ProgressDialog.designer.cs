namespace UIClient
{
    partial class ProgressDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPupil = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFsem = new System.Windows.Forms.TextBox();
            this.tbSsem = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.saveClic = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ учня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клас";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва предмету";
            // 
            // cbPupil
            // 
            this.cbPupil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPupil.FormattingEnabled = true;
            this.cbPupil.Location = new System.Drawing.Point(204, 9);
            this.cbPupil.Name = "cbPupil";
            this.cbPupil.Size = new System.Drawing.Size(283, 21);
            this.cbPupil.TabIndex = 3;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(204, 57);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(283, 21);
            this.cbClass.TabIndex = 4;
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(204, 106);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(283, 21);
            this.cbSubject.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оцінка за перший семестр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Оцінка за другий семестр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Оцінка за рік";
            // 
            // tbFsem
            // 
            this.tbFsem.Location = new System.Drawing.Point(204, 149);
            this.tbFsem.Name = "tbFsem";
            this.tbFsem.Size = new System.Drawing.Size(283, 20);
            this.tbFsem.TabIndex = 9;
            // 
            // tbSsem
            // 
            this.tbSsem.Location = new System.Drawing.Point(204, 197);
            this.tbSsem.Name = "tbSsem";
            this.tbSsem.Size = new System.Drawing.Size(283, 20);
            this.tbSsem.TabIndex = 10;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(204, 247);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(283, 20);
            this.tbYear.TabIndex = 11;
            // 
            // saveClic
            // 
            this.saveClic.Location = new System.Drawing.Point(204, 339);
            this.saveClic.Name = "saveClic";
            this.saveClic.Size = new System.Drawing.Size(121, 39);
            this.saveClic.TabIndex = 13;
            this.saveClic.Text = "Зберегти";
            this.saveClic.UseVisualStyleBackColor = true;
            this.saveClic.Click += new System.EventHandler(this.saveClic_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(367, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(2, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 132);
            this.label7.TabIndex = 15;
            // 
            // ProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 423);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveClic);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbSsem);
            this.Controls.Add(this.tbFsem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbPupil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Успішність учня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPupil;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFsem;
        private System.Windows.Forms.TextBox tbSsem;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Button saveClic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}