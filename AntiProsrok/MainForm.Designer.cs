namespace AntiProsrok
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mmFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmView = new System.Windows.Forms.ToolStripMenuItem();
            this.mmViewFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManageCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mmManageAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManageEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManageToTrash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mmManageExportToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tslToday = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSave = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbutCreateNew = new System.Windows.Forms.ToolStripButton();
            this.tsbutOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbutSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbutAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbutEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbutToTrash = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tpAll = new System.Windows.Forms.TabPage();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.tpIsOkay = new System.Windows.Forms.TabPage();
            this.dgvIsOkay = new System.Windows.Forms.DataGridView();
            this.tpSoon = new System.Windows.Forms.TabPage();
            this.dgvSoon = new System.Windows.Forms.DataGridView();
            this.tpOverdue = new System.Windows.Forms.TabPage();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.panelForGb = new System.Windows.Forms.Panel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.butFilterReset = new System.Windows.Forms.Button();
            this.butFilterApply = new System.Windows.Forms.Button();
            this.tbFilterComment = new System.Windows.Forms.TextBox();
            this.lbFIlterComment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateToTrashDO = new System.Windows.Forms.DateTimePicker();
            this.checkDateToTrash = new System.Windows.Forms.CheckBox();
            this.dtpDateToTrashOT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateCreateDO = new System.Windows.Forms.DateTimePicker();
            this.checkDateCreate = new System.Windows.Forms.CheckBox();
            this.dtpDateCreateOT = new System.Windows.Forms.DateTimePicker();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.lbFIlterCategory = new System.Windows.Forms.Label();
            this.tbFilterName = new System.Windows.Forms.TextBox();
            this.lbFIlterName = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pushTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.tpIsOkay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsOkay)).BeginInit();
            this.tpSoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoon)).BeginInit();
            this.tpOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.panelForGb.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmView,
            this.mmManage,
            this.mmHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(838, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFileCreateNew,
            this.mmFileOpen,
            this.toolStripMenuItem1,
            this.mmFileSave,
            this.mmFileSaveAs,
            this.toolStripMenuItem2,
            this.mmFileExit});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(50, 21);
            this.mmFile.Text = "Файл";
            // 
            // mmFileCreateNew
            // 
            this.mmFileCreateNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("mmFileCreateNew.Image")));
            this.mmFileCreateNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileCreateNew.Name = "mmFileCreateNew";
            this.mmFileCreateNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mmFileCreateNew.Size = new System.Drawing.Size(266, 38);
            this.mmFileCreateNew.Text = "Создать новый склад";
            this.mmFileCreateNew.Click += new System.EventHandler(this.mmFileCreateNew_Click);
            // 
            // mmFileOpen
            // 
            this.mmFileOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mmFileOpen.Image")));
            this.mmFileOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileOpen.Name = "mmFileOpen";
            this.mmFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mmFileOpen.Size = new System.Drawing.Size(266, 38);
            this.mmFileOpen.Text = "Открыть склад";
            this.mmFileOpen.Click += new System.EventHandler(this.mmFileOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(263, 6);
            // 
            // mmFileSave
            // 
            this.mmFileSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mmFileSave.Image")));
            this.mmFileSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileSave.Name = "mmFileSave";
            this.mmFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mmFileSave.Size = new System.Drawing.Size(266, 38);
            this.mmFileSave.Text = "Сохранить";
            this.mmFileSave.Click += new System.EventHandler(this.mmFileSave_Click);
            // 
            // mmFileSaveAs
            // 
            this.mmFileSaveAs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("mmFileSaveAs.Image")));
            this.mmFileSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileSaveAs.Name = "mmFileSaveAs";
            this.mmFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mmFileSaveAs.Size = new System.Drawing.Size(266, 38);
            this.mmFileSaveAs.Text = "Сохранить как";
            this.mmFileSaveAs.Click += new System.EventHandler(this.mmFileSaveAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 6);
            // 
            // mmFileExit
            // 
            this.mmFileExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileExit.Image = ((System.Drawing.Image)(resources.GetObject("mmFileExit.Image")));
            this.mmFileExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileExit.Name = "mmFileExit";
            this.mmFileExit.ShortcutKeyDisplayString = "Alt+F4";
            this.mmFileExit.Size = new System.Drawing.Size(266, 38);
            this.mmFileExit.Text = "Выход из программы";
            this.mmFileExit.Click += new System.EventHandler(this.mmFileExit_Click);
            // 
            // mmView
            // 
            this.mmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmViewFilter});
            this.mmView.Name = "mmView";
            this.mmView.Size = new System.Drawing.Size(41, 21);
            this.mmView.Text = "Вид";
            // 
            // mmViewFilter
            // 
            this.mmViewFilter.Checked = true;
            this.mmViewFilter.CheckOnClick = true;
            this.mmViewFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mmViewFilter.Image = ((System.Drawing.Image)(resources.GetObject("mmViewFilter.Image")));
            this.mmViewFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmViewFilter.Name = "mmViewFilter";
            this.mmViewFilter.Size = new System.Drawing.Size(242, 38);
            this.mmViewFilter.Text = "Показать/Скрыть Фильтр";
            this.mmViewFilter.CheckStateChanged += new System.EventHandler(this.mmViewFilter_CheckStateChanged);
            // 
            // mmManage
            // 
            this.mmManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmManageCategory,
            this.toolStripMenuItem3,
            this.mmManageAdd,
            this.mmManageEdit,
            this.mmManageToTrash,
            this.toolStripSeparator4,
            this.mmManageExportToCSV});
            this.mmManage.Name = "mmManage";
            this.mmManage.Size = new System.Drawing.Size(91, 21);
            this.mmManage.Text = "Управление";
            // 
            // mmManageCategory
            // 
            this.mmManageCategory.Image = ((System.Drawing.Image)(resources.GetObject("mmManageCategory.Image")));
            this.mmManageCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageCategory.Name = "mmManageCategory";
            this.mmManageCategory.Size = new System.Drawing.Size(204, 38);
            this.mmManageCategory.Text = "Категории";
            this.mmManageCategory.Click += new System.EventHandler(this.mmManageCategory_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 6);
            // 
            // mmManageAdd
            // 
            this.mmManageAdd.Image = ((System.Drawing.Image)(resources.GetObject("mmManageAdd.Image")));
            this.mmManageAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageAdd.Name = "mmManageAdd";
            this.mmManageAdd.Size = new System.Drawing.Size(204, 38);
            this.mmManageAdd.Text = "Добавить предмет";
            this.mmManageAdd.Click += new System.EventHandler(this.mmManageAdd_Click);
            // 
            // mmManageEdit
            // 
            this.mmManageEdit.Image = ((System.Drawing.Image)(resources.GetObject("mmManageEdit.Image")));
            this.mmManageEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageEdit.Name = "mmManageEdit";
            this.mmManageEdit.Size = new System.Drawing.Size(204, 38);
            this.mmManageEdit.Text = "Изменить предмет";
            this.mmManageEdit.Click += new System.EventHandler(this.mmManageEdit_Click);
            // 
            // mmManageToTrash
            // 
            this.mmManageToTrash.Image = ((System.Drawing.Image)(resources.GetObject("mmManageToTrash.Image")));
            this.mmManageToTrash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageToTrash.Name = "mmManageToTrash";
            this.mmManageToTrash.Size = new System.Drawing.Size(204, 38);
            this.mmManageToTrash.Text = "Удалить предмет";
            this.mmManageToTrash.Click += new System.EventHandler(this.mmManageToTrash_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // mmManageExportToCSV
            // 
            this.mmManageExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("mmManageExportToCSV.Image")));
            this.mmManageExportToCSV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageExportToCSV.Name = "mmManageExportToCSV";
            this.mmManageExportToCSV.Size = new System.Drawing.Size(204, 38);
            this.mmManageExportToCSV.Text = "Экспорт в *.CSV";
            this.mmManageExportToCSV.Click += new System.EventHandler(this.mmManageExportToCSV_Click);
            // 
            // mmHelp
            // 
            this.mmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmHelpAbout});
            this.mmHelp.Name = "mmHelp";
            this.mmHelp.Size = new System.Drawing.Size(70, 21);
            this.mmHelp.Text = "Справка";
            // 
            // mmHelpAbout
            // 
            this.mmHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("mmHelpAbout.Image")));
            this.mmHelpAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmHelpAbout.Name = "mmHelpAbout";
            this.mmHelpAbout.Size = new System.Drawing.Size(174, 38);
            this.mmHelpAbout.Text = "О программе";
            this.mmHelpAbout.Click += new System.EventHandler(this.mmHelpAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslToday,
            this.tslDateTime,
            this.statusSave});
            this.statusBar.Location = new System.Drawing.Point(0, 399);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(838, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // tslToday
            // 
            this.tslToday.Name = "tslToday";
            this.tslToday.Size = new System.Drawing.Size(60, 17);
            this.tslToday.Text = "Сегодня:";
            // 
            // tslDateTime
            // 
            this.tslDateTime.Name = "tslDateTime";
            this.tslDateTime.Size = new System.Drawing.Size(105, 17);
            this.tslDateTime.Text = "21.03.2020 10:07";
            // 
            // statusSave
            // 
            this.statusSave.ForeColor = System.Drawing.Color.Green;
            this.statusSave.Name = "statusSave";
            this.statusSave.Size = new System.Drawing.Size(656, 17);
            this.statusSave.Spring = true;
            this.statusSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbutCreateNew,
            this.tsbutOpen,
            this.tsbutSave,
            this.toolStripSeparator1,
            this.tsbutAdd,
            this.tsbutEdit,
            this.tsbutToTrash});
            this.tsMain.Location = new System.Drawing.Point(0, 25);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(605, 31);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbutCreateNew
            // 
            this.tsbutCreateNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbutCreateNew.Image")));
            this.tsbutCreateNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutCreateNew.Name = "tsbutCreateNew";
            this.tsbutCreateNew.Size = new System.Drawing.Size(28, 28);
            this.tsbutCreateNew.Text = "Создать новый склад";
            this.tsbutCreateNew.Click += new System.EventHandler(this.mmFileCreateNew_Click);
            // 
            // tsbutOpen
            // 
            this.tsbutOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbutOpen.Image")));
            this.tsbutOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutOpen.Name = "tsbutOpen";
            this.tsbutOpen.Size = new System.Drawing.Size(28, 28);
            this.tsbutOpen.Text = "Открыть существующий склад";
            this.tsbutOpen.Click += new System.EventHandler(this.mmFileOpen_Click);
            // 
            // tsbutSave
            // 
            this.tsbutSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbutSave.Image")));
            this.tsbutSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutSave.Name = "tsbutSave";
            this.tsbutSave.Size = new System.Drawing.Size(28, 28);
            this.tsbutSave.Text = "Сохранить";
            this.tsbutSave.Click += new System.EventHandler(this.mmFileSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbutAdd
            // 
            this.tsbutAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbutAdd.Image")));
            this.tsbutAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutAdd.Name = "tsbutAdd";
            this.tsbutAdd.Size = new System.Drawing.Size(94, 28);
            this.tsbutAdd.Text = "Добавить";
            this.tsbutAdd.ToolTipText = "Добавить предмет на склад";
            this.tsbutAdd.Click += new System.EventHandler(this.mmManageAdd_Click);
            // 
            // tsbutEdit
            // 
            this.tsbutEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbutEdit.Image")));
            this.tsbutEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutEdit.Name = "tsbutEdit";
            this.tsbutEdit.Size = new System.Drawing.Size(94, 28);
            this.tsbutEdit.Text = "Изменить";
            this.tsbutEdit.ToolTipText = "Изменить информацию о предмете";
            this.tsbutEdit.Click += new System.EventHandler(this.mmManageEdit_Click);
            // 
            // tsbutToTrash
            // 
            this.tsbutToTrash.Image = ((System.Drawing.Image)(resources.GetObject("tsbutToTrash.Image")));
            this.tsbutToTrash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutToTrash.Name = "tsbutToTrash";
            this.tsbutToTrash.Size = new System.Drawing.Size(83, 28);
            this.tsbutToTrash.Text = "Удалить";
            this.tsbutToTrash.ToolTipText = "Удалить предмет со склада";
            this.tsbutToTrash.Click += new System.EventHandler(this.mmManageToTrash_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tpAll);
            this.tabControlMain.Controls.Add(this.tpIsOkay);
            this.tabControlMain.Controls.Add(this.tpSoon);
            this.tabControlMain.Controls.Add(this.tpOverdue);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 56);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(605, 343);
            this.tabControlMain.TabIndex = 3;
            // 
            // tpAll
            // 
            this.tpAll.Controls.Add(this.dgvAll);
            this.tpAll.Location = new System.Drawing.Point(4, 24);
            this.tpAll.Name = "tpAll";
            this.tpAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpAll.Size = new System.Drawing.Size(597, 315);
            this.tpAll.TabIndex = 0;
            this.tpAll.Text = "Все предметы";
            this.tpAll.UseVisualStyleBackColor = true;
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.AllowUserToResizeColumns = false;
            this.dgvAll.AllowUserToResizeRows = false;
            this.dgvAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAll.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAll.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAll.Location = new System.Drawing.Point(3, 3);
            this.dgvAll.MultiSelect = false;
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.RowHeadersVisible = false;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAll.ShowCellErrors = false;
            this.dgvAll.ShowCellToolTips = false;
            this.dgvAll.ShowEditingIcon = false;
            this.dgvAll.ShowRowErrors = false;
            this.dgvAll.Size = new System.Drawing.Size(591, 309);
            this.dgvAll.TabIndex = 0;
            // 
            // tpIsOkay
            // 
            this.tpIsOkay.BackColor = System.Drawing.SystemColors.Window;
            this.tpIsOkay.Controls.Add(this.dgvIsOkay);
            this.tpIsOkay.Location = new System.Drawing.Point(4, 24);
            this.tpIsOkay.Name = "tpIsOkay";
            this.tpIsOkay.Padding = new System.Windows.Forms.Padding(3);
            this.tpIsOkay.Size = new System.Drawing.Size(597, 315);
            this.tpIsOkay.TabIndex = 5;
            this.tpIsOkay.Text = "Срок в порядке";
            // 
            // dgvIsOkay
            // 
            this.dgvIsOkay.AllowUserToAddRows = false;
            this.dgvIsOkay.AllowUserToDeleteRows = false;
            this.dgvIsOkay.AllowUserToResizeColumns = false;
            this.dgvIsOkay.AllowUserToResizeRows = false;
            this.dgvIsOkay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsOkay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIsOkay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIsOkay.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIsOkay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsOkay.Location = new System.Drawing.Point(3, 3);
            this.dgvIsOkay.MultiSelect = false;
            this.dgvIsOkay.Name = "dgvIsOkay";
            this.dgvIsOkay.RowHeadersVisible = false;
            this.dgvIsOkay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsOkay.ShowCellErrors = false;
            this.dgvIsOkay.ShowCellToolTips = false;
            this.dgvIsOkay.ShowEditingIcon = false;
            this.dgvIsOkay.ShowRowErrors = false;
            this.dgvIsOkay.Size = new System.Drawing.Size(591, 309);
            this.dgvIsOkay.TabIndex = 0;
            // 
            // tpSoon
            // 
            this.tpSoon.Controls.Add(this.dgvSoon);
            this.tpSoon.Location = new System.Drawing.Point(4, 24);
            this.tpSoon.Name = "tpSoon";
            this.tpSoon.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoon.Size = new System.Drawing.Size(597, 315);
            this.tpSoon.TabIndex = 1;
            this.tpSoon.Text = "Скоро закончится срок годности";
            this.tpSoon.UseVisualStyleBackColor = true;
            // 
            // dgvSoon
            // 
            this.dgvSoon.AllowUserToAddRows = false;
            this.dgvSoon.AllowUserToDeleteRows = false;
            this.dgvSoon.AllowUserToResizeColumns = false;
            this.dgvSoon.AllowUserToResizeRows = false;
            this.dgvSoon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoon.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoon.Location = new System.Drawing.Point(3, 3);
            this.dgvSoon.MultiSelect = false;
            this.dgvSoon.Name = "dgvSoon";
            this.dgvSoon.RowHeadersVisible = false;
            this.dgvSoon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoon.ShowCellErrors = false;
            this.dgvSoon.ShowCellToolTips = false;
            this.dgvSoon.ShowEditingIcon = false;
            this.dgvSoon.ShowRowErrors = false;
            this.dgvSoon.Size = new System.Drawing.Size(591, 309);
            this.dgvSoon.TabIndex = 0;
            // 
            // tpOverdue
            // 
            this.tpOverdue.Controls.Add(this.dgvOverdue);
            this.tpOverdue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpOverdue.Location = new System.Drawing.Point(4, 24);
            this.tpOverdue.Name = "tpOverdue";
            this.tpOverdue.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverdue.Size = new System.Drawing.Size(597, 315);
            this.tpOverdue.TabIndex = 4;
            this.tpOverdue.Text = "Просрочка";
            this.tpOverdue.UseVisualStyleBackColor = true;
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.AllowUserToResizeColumns = false;
            this.dgvOverdue.AllowUserToResizeRows = false;
            this.dgvOverdue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverdue.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverdue.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverdue.Location = new System.Drawing.Point(3, 3);
            this.dgvOverdue.MultiSelect = false;
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.RowHeadersVisible = false;
            this.dgvOverdue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverdue.ShowCellErrors = false;
            this.dgvOverdue.ShowCellToolTips = false;
            this.dgvOverdue.ShowEditingIcon = false;
            this.dgvOverdue.ShowRowErrors = false;
            this.dgvOverdue.Size = new System.Drawing.Size(591, 309);
            this.dgvOverdue.TabIndex = 0;
            // 
            // panelForGb
            // 
            this.panelForGb.Controls.Add(this.gbFilter);
            this.panelForGb.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelForGb.Location = new System.Drawing.Point(605, 25);
            this.panelForGb.Name = "panelForGb";
            this.panelForGb.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.panelForGb.Size = new System.Drawing.Size(233, 374);
            this.panelForGb.TabIndex = 4;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.butFilterReset);
            this.gbFilter.Controls.Add(this.butFilterApply);
            this.gbFilter.Controls.Add(this.tbFilterComment);
            this.gbFilter.Controls.Add(this.lbFIlterComment);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.label5);
            this.gbFilter.Controls.Add(this.dtpDateToTrashDO);
            this.gbFilter.Controls.Add(this.checkDateToTrash);
            this.gbFilter.Controls.Add(this.dtpDateToTrashOT);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.dtpDateCreateDO);
            this.gbFilter.Controls.Add(this.checkDateCreate);
            this.gbFilter.Controls.Add(this.dtpDateCreateOT);
            this.gbFilter.Controls.Add(this.cbFilterCategory);
            this.gbFilter.Controls.Add(this.lbFIlterCategory);
            this.gbFilter.Controls.Add(this.tbFilterName);
            this.gbFilter.Controls.Add(this.lbFIlterName);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Location = new System.Drawing.Point(6, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(221, 368);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
            // 
            // butFilterReset
            // 
            this.butFilterReset.Enabled = false;
            this.butFilterReset.Location = new System.Drawing.Point(6, 335);
            this.butFilterReset.Name = "butFilterReset";
            this.butFilterReset.Size = new System.Drawing.Size(209, 23);
            this.butFilterReset.TabIndex = 10;
            this.butFilterReset.Text = "Сбросить фильтр";
            this.butFilterReset.UseVisualStyleBackColor = true;
            this.butFilterReset.Click += new System.EventHandler(this.butFilterReset_Click);
            // 
            // butFilterApply
            // 
            this.butFilterApply.Location = new System.Drawing.Point(6, 306);
            this.butFilterApply.Name = "butFilterApply";
            this.butFilterApply.Size = new System.Drawing.Size(209, 23);
            this.butFilterApply.TabIndex = 9;
            this.butFilterApply.Text = "Применить фильтр";
            this.butFilterApply.UseVisualStyleBackColor = true;
            this.butFilterApply.Click += new System.EventHandler(this.butFilterApply_Click);
            // 
            // tbFilterComment
            // 
            this.tbFilterComment.Location = new System.Drawing.Point(6, 121);
            this.tbFilterComment.Name = "tbFilterComment";
            this.tbFilterComment.Size = new System.Drawing.Size(209, 21);
            this.tbFilterComment.TabIndex = 2;
            // 
            // lbFIlterComment
            // 
            this.lbFIlterComment.AutoSize = true;
            this.lbFIlterComment.Location = new System.Drawing.Point(3, 103);
            this.lbFIlterComment.Name = "lbFIlterComment";
            this.lbFIlterComment.Size = new System.Drawing.Size(83, 15);
            this.lbFIlterComment.TabIndex = 18;
            this.lbFIlterComment.Text = "Примечание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "До:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "От:";
            // 
            // dtpDateToTrashDO
            // 
            this.dtpDateToTrashDO.Enabled = false;
            this.dtpDateToTrashDO.Location = new System.Drawing.Point(35, 279);
            this.dtpDateToTrashDO.Name = "dtpDateToTrashDO";
            this.dtpDateToTrashDO.Size = new System.Drawing.Size(180, 21);
            this.dtpDateToTrashDO.TabIndex = 8;
            // 
            // checkDateToTrash
            // 
            this.checkDateToTrash.AutoSize = true;
            this.checkDateToTrash.Location = new System.Drawing.Point(6, 227);
            this.checkDateToTrash.Name = "checkDateToTrash";
            this.checkDateToTrash.Size = new System.Drawing.Size(132, 19);
            this.checkDateToTrash.TabIndex = 6;
            this.checkDateToTrash.Text = "По сроку годности";
            this.checkDateToTrash.UseVisualStyleBackColor = true;
            this.checkDateToTrash.CheckStateChanged += new System.EventHandler(this.checkDateToTrash_CheckStateChanged);
            // 
            // dtpDateToTrashOT
            // 
            this.dtpDateToTrashOT.Enabled = false;
            this.dtpDateToTrashOT.Location = new System.Drawing.Point(35, 252);
            this.dtpDateToTrashOT.Name = "dtpDateToTrashOT";
            this.dtpDateToTrashOT.Size = new System.Drawing.Size(180, 21);
            this.dtpDateToTrashOT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "От:";
            // 
            // dtpDateCreateDO
            // 
            this.dtpDateCreateDO.Enabled = false;
            this.dtpDateCreateDO.Location = new System.Drawing.Point(35, 200);
            this.dtpDateCreateDO.Name = "dtpDateCreateDO";
            this.dtpDateCreateDO.Size = new System.Drawing.Size(180, 21);
            this.dtpDateCreateDO.TabIndex = 5;
            // 
            // checkDateCreate
            // 
            this.checkDateCreate.AutoSize = true;
            this.checkDateCreate.Location = new System.Drawing.Point(6, 148);
            this.checkDateCreate.Name = "checkDateCreate";
            this.checkDateCreate.Size = new System.Drawing.Size(157, 19);
            this.checkDateCreate.TabIndex = 3;
            this.checkDateCreate.Text = "По дате изготовления";
            this.checkDateCreate.UseVisualStyleBackColor = true;
            this.checkDateCreate.CheckStateChanged += new System.EventHandler(this.checkDateCreate_CheckStateChanged);
            // 
            // dtpDateCreateOT
            // 
            this.dtpDateCreateOT.Enabled = false;
            this.dtpDateCreateOT.Location = new System.Drawing.Point(35, 173);
            this.dtpDateCreateOT.Name = "dtpDateCreateOT";
            this.dtpDateCreateOT.Size = new System.Drawing.Size(180, 21);
            this.dtpDateCreateOT.TabIndex = 4;
            // 
            // cbFilterCategory
            // 
            this.cbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCategory.FormattingEnabled = true;
            this.cbFilterCategory.Items.AddRange(new object[] {
            ""});
            this.cbFilterCategory.Location = new System.Drawing.Point(6, 77);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(209, 23);
            this.cbFilterCategory.TabIndex = 1;
            // 
            // lbFIlterCategory
            // 
            this.lbFIlterCategory.AutoSize = true;
            this.lbFIlterCategory.Location = new System.Drawing.Point(3, 59);
            this.lbFIlterCategory.Name = "lbFIlterCategory";
            this.lbFIlterCategory.Size = new System.Drawing.Size(72, 15);
            this.lbFIlterCategory.TabIndex = 2;
            this.lbFIlterCategory.Text = "Категория:";
            // 
            // tbFilterName
            // 
            this.tbFilterName.Location = new System.Drawing.Point(6, 35);
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.Size = new System.Drawing.Size(209, 21);
            this.tbFilterName.TabIndex = 0;
            // 
            // lbFIlterName
            // 
            this.lbFIlterName.AutoSize = true;
            this.lbFIlterName.Location = new System.Drawing.Point(3, 17);
            this.lbFIlterName.Name = "lbFIlterName";
            this.lbFIlterName.Size = new System.Drawing.Size(67, 15);
            this.lbFIlterName.TabIndex = 0;
            this.lbFIlterName.Text = "Название:";
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pushTimer
            // 
            this.pushTimer.Interval = 1000;
            this.pushTimer.Tick += new System.EventHandler(this.pushTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 421);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.panelForGb);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(850, 460);
            this.Name = "MainForm";
            this.Text = "АнтиПросрочка V1.1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tpAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.tpIsOkay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsOkay)).EndInit();
            this.tpSoon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoon)).EndInit();
            this.tpOverdue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.panelForGb.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mmFileCreateNew;
        private System.Windows.Forms.ToolStripMenuItem mmFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmFileSave;
        private System.Windows.Forms.ToolStripMenuItem mmFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mmFileExit;
        private System.Windows.Forms.ToolStripMenuItem mmView;
        private System.Windows.Forms.ToolStripMenuItem mmViewFilter;
        private System.Windows.Forms.ToolStripMenuItem mmManage;
        private System.Windows.Forms.ToolStripMenuItem mmManageCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mmManageAdd;
        private System.Windows.Forms.ToolStripMenuItem mmManageEdit;
        private System.Windows.Forms.ToolStripMenuItem mmManageToTrash;
        private System.Windows.Forms.ToolStripMenuItem mmHelp;
        private System.Windows.Forms.ToolStripMenuItem mmHelpAbout;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel tslToday;
        private System.Windows.Forms.ToolStripStatusLabel tslDateTime;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbutCreateNew;
        private System.Windows.Forms.ToolStripButton tsbutOpen;
        private System.Windows.Forms.ToolStripButton tsbutSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbutAdd;
        private System.Windows.Forms.ToolStripButton tsbutEdit;
        private System.Windows.Forms.ToolStripButton tsbutToTrash;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tpAll;
        private System.Windows.Forms.TabPage tpSoon;
        private System.Windows.Forms.Panel panelForGb;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.DataGridView dgvSoon;
        private System.Windows.Forms.TabPage tpOverdue;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.DateTimePicker dtpDateCreateDO;
        private System.Windows.Forms.CheckBox checkDateCreate;
        private System.Windows.Forms.DateTimePicker dtpDateCreateOT;
        private System.Windows.Forms.ComboBox cbFilterCategory;
        private System.Windows.Forms.Label lbFIlterCategory;
        private System.Windows.Forms.TextBox tbFilterName;
        private System.Windows.Forms.Label lbFIlterName;
        private System.Windows.Forms.TextBox tbFilterComment;
        private System.Windows.Forms.Label lbFIlterComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateToTrashDO;
        private System.Windows.Forms.CheckBox checkDateToTrash;
        private System.Windows.Forms.DateTimePicker dtpDateToTrashOT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butFilterReset;
        private System.Windows.Forms.Button butFilterApply;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mmManageExportToCSV;
        private System.Windows.Forms.TabPage tpIsOkay;
        private System.Windows.Forms.DataGridView dgvIsOkay;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripStatusLabel statusSave;
        private System.Windows.Forms.Timer pushTimer;
    }
}

