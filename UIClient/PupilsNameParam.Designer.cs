namespace UIClient
{
    partial class PupilsNameParam
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
            this.startFilter = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPupilsName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.startFilter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPupilsName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 78);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // startFilter
            // 
            this.startFilter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.startFilter.Location = new System.Drawing.Point(3, 38);
            this.startFilter.Name = "startFilter";
            this.startFilter.Size = new System.Drawing.Size(153, 23);
            this.startFilter.TabIndex = 2;
            this.startFilter.Text = "Фильтровать";
            this.startFilter.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cancel.Location = new System.Drawing.Point(162, 38);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(153, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО учиника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPupilsName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbPupilsName, 2);
            this.cbPupilsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPupilsName.FormattingEnabled = true;
            this.cbPupilsName.Location = new System.Drawing.Point(3, 18);
            this.cbPupilsName.Name = "cbPupilsName";
            this.cbPupilsName.Size = new System.Drawing.Size(312, 21);
            this.cbPupilsName.TabIndex = 4;
            // 
            // PupilsNameParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 78);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PupilsNameParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введите ФИО ученика";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button startFilter;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbPupilsName;
    }
}