namespace UIClient
{
    partial class PupilsBirthdayParam
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.startFilter = new System.Windows.Forms.Button();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.startFilter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.date1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.date2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 108);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Даты рождения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(130, 80);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(122, 25);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // startFilter
            // 
            this.startFilter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startFilter.Location = new System.Drawing.Point(3, 80);
            this.startFilter.Name = "startFilter";
            this.startFilter.Size = new System.Drawing.Size(121, 25);
            this.startFilter.TabIndex = 2;
            this.startFilter.Text = "Фильтровать";
            this.startFilter.UseVisualStyleBackColor = true;
            // 
            // date1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.date1, 2);
            this.date1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date1.Location = new System.Drawing.Point(3, 22);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(249, 20);
            this.date1.TabIndex = 4;
            // 
            // date2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.date2, 2);
            this.date2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date2.Location = new System.Drawing.Point(3, 48);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(249, 20);
            this.date2.TabIndex = 5;
            // 
            // PupilsBirthdayParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 108);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PupilsBirthdayParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выборка по дате рождения";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button startFilter;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.DateTimePicker date2;
    }
}