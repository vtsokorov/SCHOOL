namespace UIClient
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceQualification = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceEducation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.referenceNationality = new System.Windows.Forms.ToolStripMenuItem();
            this.NationalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceFamily = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.выборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ученикToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNamePupils = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDateBirthday = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportPupilsList = new System.Windows.Forms.ToolStripMenuItem();
            this.cardLoadTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApp = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.disconnectButton = new System.Windows.Forms.ToolStripButton();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.contextTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.текст1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текст2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.mainMenu.SuspendLayout();
            this.mainToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.contextTreeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Location = new System.Drawing.Point(0, 659);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Size = new System.Drawing.Size(1087, 22);
            this.mainStatusBar.TabIndex = 3;
            this.mainStatusBar.Text = "statusStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.выборкаToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1087, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnect,
            this.settings,
            this.exitApp});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // disconnect
            // 
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(196, 22);
            this.disconnect.Text = "Отсоединиться от БД";
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // settings
            // 
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(196, 22);
            this.settings.Text = "Настройки";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(196, 22);
            this.exitApp.Text = "Выход";
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem,
            this.toolStripSeparator1,
            this.referenceNationality});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceQualification,
            this.referenceEducation});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.teacherToolStripMenuItem.Text = "Учитель";
            // 
            // referenceQualification
            // 
            this.referenceQualification.Name = "referenceQualification";
            this.referenceQualification.Size = new System.Drawing.Size(160, 22);
            this.referenceQualification.Text = "Квалификация";
            this.referenceQualification.Click += new System.EventHandler(this.referenceQualification_Click);
            // 
            // referenceEducation
            // 
            this.referenceEducation.Name = "referenceEducation";
            this.referenceEducation.Size = new System.Drawing.Size(160, 22);
            this.referenceEducation.Text = "Образование";
            this.referenceEducation.Click += new System.EventHandler(this.referenceEducation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // referenceNationality
            // 
            this.referenceNationality.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NationalityToolStripMenuItem,
            this.referenceFamily,
            this.referenceHealth});
            this.referenceNationality.Name = "referenceNationality";
            this.referenceNationality.Size = new System.Drawing.Size(128, 22);
            this.referenceNationality.Text = "Ученик";
            // 
            // NationalityToolStripMenuItem
            // 
            this.NationalityToolStripMenuItem.Name = "NationalityToolStripMenuItem";
            this.NationalityToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.NationalityToolStripMenuItem.Text = "Национальность";
            this.NationalityToolStripMenuItem.Click += new System.EventHandler(this.NationalityToolStripMenuItem_Click_1);
            // 
            // referenceFamily
            // 
            this.referenceFamily.Name = "referenceFamily";
            this.referenceFamily.Size = new System.Drawing.Size(169, 22);
            this.referenceFamily.Text = "Семья";
            this.referenceFamily.Click += new System.EventHandler(this.referenceFamily_Click);
            // 
            // referenceHealth
            // 
            this.referenceHealth.Name = "referenceHealth";
            this.referenceHealth.Size = new System.Drawing.Size(169, 22);
            this.referenceHealth.Text = "Здоровье";
            this.referenceHealth.Click += new System.EventHandler(this.referenceHealth_Click);
            // 
            // выборкаToolStripMenuItem
            // 
            this.выборкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ученикToolStripMenuItem1,
            this.toolStripSeparator2,
            this.ученикToolStripMenuItem2});
            this.выборкаToolStripMenuItem.Name = "выборкаToolStripMenuItem";
            this.выборкаToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.выборкаToolStripMenuItem.Text = "Выборка";
            // 
            // ученикToolStripMenuItem1
            // 
            this.ученикToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectTeacher,
            this.selectCategory,
            this.selectLoading});
            this.ученикToolStripMenuItem1.Name = "ученикToolStripMenuItem1";
            this.ученикToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.ученикToolStripMenuItem1.Text = "Учитель";
            // 
            // selectTeacher
            // 
            this.selectTeacher.Name = "selectTeacher";
            this.selectTeacher.Size = new System.Drawing.Size(214, 22);
            this.selectTeacher.Text = "Выборка по ФИО";
            this.selectTeacher.Click += new System.EventHandler(this.selectTeacher_Click);
            // 
            // selectCategory
            // 
            this.selectCategory.Name = "selectCategory";
            this.selectCategory.Size = new System.Drawing.Size(214, 22);
            this.selectCategory.Text = "Выборка по категории";
            this.selectCategory.Click += new System.EventHandler(this.selectCategory_Click);
            // 
            // selectLoading
            // 
            this.selectLoading.Name = "selectLoading";
            this.selectLoading.Size = new System.Drawing.Size(214, 22);
            this.selectLoading.Text = "Нагрузка преподователя";
            this.selectLoading.Click += new System.EventHandler(this.selectLoading_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // ученикToolStripMenuItem2
            // 
            this.ученикToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectNamePupils,
            this.selectProgress,
            this.selectAttendance,
            this.selectDateBirthday});
            this.ученикToolStripMenuItem2.Name = "ученикToolStripMenuItem2";
            this.ученикToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.ученикToolStripMenuItem2.Text = "Ученик";
            // 
            // selectNamePupils
            // 
            this.selectNamePupils.Name = "selectNamePupils";
            this.selectNamePupils.Size = new System.Drawing.Size(232, 22);
            this.selectNamePupils.Text = "Выборка по ФИО";
            this.selectNamePupils.Click += new System.EventHandler(this.selectNamePupils_Click);
            // 
            // selectProgress
            // 
            this.selectProgress.Name = "selectProgress";
            this.selectProgress.Size = new System.Drawing.Size(232, 22);
            this.selectProgress.Text = "Успеваемост ученика";
            this.selectProgress.Click += new System.EventHandler(this.selectProgress_Click);
            // 
            // selectAttendance
            // 
            this.selectAttendance.Name = "selectAttendance";
            this.selectAttendance.Size = new System.Drawing.Size(232, 22);
            this.selectAttendance.Text = "Посещаемост ученика";
            this.selectAttendance.Click += new System.EventHandler(this.selectAttendance_Click);
            // 
            // selectDateBirthday
            // 
            this.selectDateBirthday.Name = "selectDateBirthday";
            this.selectDateBirthday.Size = new System.Drawing.Size(232, 22);
            this.selectDateBirthday.Text = "Ввыборка по дате рождения";
            this.selectDateBirthday.Click += new System.EventHandler(this.selectDateBirthday_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportPupilsList,
            this.cardLoadTeacher});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // generateReportPupilsList
            // 
            this.generateReportPupilsList.Name = "generateReportPupilsList";
            this.generateReportPupilsList.Size = new System.Drawing.Size(265, 22);
            this.generateReportPupilsList.Text = "Списочный состав учеников";
            this.generateReportPupilsList.Click += new System.EventHandler(this.generateReportPupilsList_Click);
            // 
            // cardLoadTeacher
            // 
            this.cardLoadTeacher.Name = "cardLoadTeacher";
            this.cardLoadTeacher.Size = new System.Drawing.Size(265, 22);
            this.cardLoadTeacher.Text = "Карточка нагрузки преподователя";
            this.cardLoadTeacher.Click += new System.EventHandler(this.cardLoadTeacher_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutApp});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutApp
            // 
            this.aboutApp.Name = "aboutApp";
            this.aboutApp.Size = new System.Drawing.Size(149, 22);
            this.aboutApp.Text = "О программе";
            this.aboutApp.Click += new System.EventHandler(this.aboutApp_Click);
            // 
            // mainToolBar
            // 
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectButton,
            this.settingsButton,
            this.toolStripSeparator3,
            this.addButton,
            this.editButton,
            this.refreshButton,
            this.deleteButton,
            this.saveButton,
            this.toolStripSeparator4});
            this.mainToolBar.Location = new System.Drawing.Point(0, 24);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolBar.Size = new System.Drawing.Size(1087, 25);
            this.mainToolBar.TabIndex = 1;
            this.mainToolBar.Text = "toolStrip1";
            // 
            // disconnectButton
            // 
            this.disconnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("disconnectButton.Image")));
            this.disconnectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(23, 22);
            this.disconnectButton.Text = "toolStripButton1";
            this.disconnectButton.ToolTipText = "Отсоединиться от БД";
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(23, 22);
            this.settingsButton.Text = "toolStripButton2";
            this.settingsButton.ToolTipText = "Настройки";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 22);
            this.addButton.Text = "toolStripButton1";
            this.addButton.ToolTipText = "Добавить запись";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(23, 22);
            this.editButton.Text = "Редактировать запись";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 22);
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 610);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(338, 610);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.selectNode);
            // 
            // mainGrid
            // 
            this.mainGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 0);
            this.mainGrid.MultiSelect = false;
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(745, 610);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectRow);
            // 
            // contextTreeMenu
            // 
            this.contextTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текст1ToolStripMenuItem,
            this.текст2ToolStripMenuItem});
            this.contextTreeMenu.Name = "contextMenuStrip1";
            this.contextTreeMenu.Size = new System.Drawing.Size(172, 48);
            // 
            // текст1ToolStripMenuItem
            // 
            this.текст1ToolStripMenuItem.Name = "текст1ToolStripMenuItem";
            this.текст1ToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.текст1ToolStripMenuItem.Text = "Перевести класс";
            // 
            // текст2ToolStripMenuItem
            // 
            this.текст2ToolStripMenuItem.Name = "текст2ToolStripMenuItem";
            this.текст2ToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.текст2ToolStripMenuItem.Text = "Выпустить класс";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Home.png");
            this.imageList.Images.SetKeyName(1, "clients.png");
            this.imageList.Images.SetKeyName(2, "User.png");
            this.imageList.Images.SetKeyName(3, "key.png");
            this.imageList.Images.SetKeyName(4, "right.png");
            this.imageList.Images.SetKeyName(5, "folderEdite.png");
            this.imageList.Images.SetKeyName(6, "folderDelete.png");
            this.imageList.Images.SetKeyName(7, "folderAdd.png");
            this.imageList.Images.SetKeyName(8, "folderUpdate.png");
            this.imageList.Images.SetKeyName(9, "connect1.png");
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.сloseWindow);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.contextTreeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutApp;
        private System.Windows.Forms.ToolStripMenuItem disconnect;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem текст1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текст2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceQualification;
        private System.Windows.Forms.ToolStripMenuItem referenceEducation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem referenceNationality;
        private System.Windows.Forms.ToolStripMenuItem NationalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceFamily;
        private System.Windows.Forms.ToolStripMenuItem referenceHealth;
        public System.Windows.Forms.DataGridView mainGrid;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem ученикToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ученикToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectNamePupils;
        private System.Windows.Forms.ToolStripMenuItem selectProgress;
        private System.Windows.Forms.ToolStripMenuItem selectAttendance;
        private System.Windows.Forms.ToolStripMenuItem selectDateBirthday;
        private System.Windows.Forms.ToolStripMenuItem selectTeacher;
        private System.Windows.Forms.ToolStripMenuItem selectCategory;
        private System.Windows.Forms.ToolStripMenuItem selectLoading;
        private System.Windows.Forms.ToolStripMenuItem generateReportPupilsList;
        private System.Windows.Forms.ToolStripMenuItem cardLoadTeacher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton disconnectButton;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        public System.Windows.Forms.StatusStrip mainStatusBar;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

