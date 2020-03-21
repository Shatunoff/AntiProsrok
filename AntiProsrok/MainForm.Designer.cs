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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tpAll = new System.Windows.Forms.TabPage();
            this.tpSoon = new System.Windows.Forms.TabPage();
            this.tslToday = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbTrash = new System.Windows.Forms.TabPage();
            this.mmFileCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mmFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManageCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mmManageAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManageEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManageToTrash = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForGb = new System.Windows.Forms.Panel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.mmView = new System.Windows.Forms.ToolStripMenuItem();
            this.mmViewFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbutCreateNew = new System.Windows.Forms.ToolStripButton();
            this.tsbutOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbutSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbutManageCategory = new System.Windows.Forms.ToolStripButton();
            this.tsbutAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbutEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbutToTrash = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbutAbout = new System.Windows.Forms.ToolStripButton();
            this.tstbQuickSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tslQuickSearch = new System.Windows.Forms.ToolStripLabel();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.dgvSoon = new System.Windows.Forms.DataGridView();
            this.dgvTrash = new System.Windows.Forms.DataGridView();
            this.tpOverdue = new System.Windows.Forms.TabPage();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbFIlterName = new System.Windows.Forms.Label();
            this.tbFilterName = new System.Windows.Forms.TextBox();
            this.lbFIlterCategory = new System.Windows.Forms.Label();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.dtpDateCreateOT = new System.Windows.Forms.DateTimePicker();
            this.checkDateCreate = new System.Windows.Forms.CheckBox();
            this.dtpDateCreateDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateToTrashDO = new System.Windows.Forms.DateTimePicker();
            this.checkDateToTrash = new System.Windows.Forms.CheckBox();
            this.dtpDateToTrashOT = new System.Windows.Forms.DateTimePicker();
            this.tbFilterComment = new System.Windows.Forms.TextBox();
            this.lbFIlterComment = new System.Windows.Forms.Label();
            this.butFilterApply = new System.Windows.Forms.Button();
            this.butFilterReset = new System.Windows.Forms.Button();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mmManageExportToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tpAll.SuspendLayout();
            this.tpSoon.SuspendLayout();
            this.tbTrash.SuspendLayout();
            this.panelForGb.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrash)).BeginInit();
            this.tpOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
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
            this.mainMenu.Size = new System.Drawing.Size(824, 25);
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
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslToday,
            this.tslDateTime});
            this.statusBar.Location = new System.Drawing.Point(0, 417);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(824, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbutCreateNew,
            this.tsbutOpen,
            this.tsbutSave,
            this.toolStripSeparator1,
            this.tsbutManageCategory,
            this.toolStripSeparator3,
            this.tsbutAdd,
            this.tsbutEdit,
            this.tsbutToTrash,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.tsbutAbout,
            this.tstbQuickSearch,
            this.tslQuickSearch});
            this.tsMain.Location = new System.Drawing.Point(0, 25);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(591, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tpAll);
            this.tabControlMain.Controls.Add(this.tpSoon);
            this.tabControlMain.Controls.Add(this.tpOverdue);
            this.tabControlMain.Controls.Add(this.tbTrash);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 50);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(591, 367);
            this.tabControlMain.TabIndex = 3;
            // 
            // tpAll
            // 
            this.tpAll.Controls.Add(this.dgvAll);
            this.tpAll.Location = new System.Drawing.Point(4, 24);
            this.tpAll.Name = "tpAll";
            this.tpAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpAll.Size = new System.Drawing.Size(583, 339);
            this.tpAll.TabIndex = 0;
            this.tpAll.Text = "Все";
            this.tpAll.UseVisualStyleBackColor = true;
            // 
            // tpSoon
            // 
            this.tpSoon.Controls.Add(this.dgvSoon);
            this.tpSoon.Location = new System.Drawing.Point(4, 24);
            this.tpSoon.Name = "tpSoon";
            this.tpSoon.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoon.Size = new System.Drawing.Size(583, 339);
            this.tpSoon.TabIndex = 1;
            this.tpSoon.Text = "Скоро закончится";
            this.tpSoon.UseVisualStyleBackColor = true;
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
            // tbTrash
            // 
            this.tbTrash.Controls.Add(this.dgvTrash);
            this.tbTrash.Location = new System.Drawing.Point(4, 24);
            this.tbTrash.Name = "tbTrash";
            this.tbTrash.Padding = new System.Windows.Forms.Padding(3);
            this.tbTrash.Size = new System.Drawing.Size(583, 339);
            this.tbTrash.TabIndex = 3;
            this.tbTrash.Text = "Корзина";
            this.tbTrash.UseVisualStyleBackColor = true;
            // 
            // mmFileCreateNew
            // 
            this.mmFileCreateNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("mmFileCreateNew.Image")));
            this.mmFileCreateNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileCreateNew.Name = "mmFileCreateNew";
            this.mmFileCreateNew.Size = new System.Drawing.Size(220, 38);
            this.mmFileCreateNew.Text = "Создать новый склад";
            // 
            // mmFileOpen
            // 
            this.mmFileOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mmFileOpen.Image")));
            this.mmFileOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileOpen.Name = "mmFileOpen";
            this.mmFileOpen.Size = new System.Drawing.Size(220, 38);
            this.mmFileOpen.Text = "Открыть склад";
            // 
            // mmFileExit
            // 
            this.mmFileExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileExit.Image = ((System.Drawing.Image)(resources.GetObject("mmFileExit.Image")));
            this.mmFileExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileExit.Name = "mmFileExit";
            this.mmFileExit.Size = new System.Drawing.Size(220, 38);
            this.mmFileExit.Text = "Выход из программы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 6);
            // 
            // mmFileSave
            // 
            this.mmFileSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mmFileSave.Image")));
            this.mmFileSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileSave.Name = "mmFileSave";
            this.mmFileSave.Size = new System.Drawing.Size(220, 38);
            this.mmFileSave.Text = "Сохранить";
            // 
            // mmFileSaveAs
            // 
            this.mmFileSaveAs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("mmFileSaveAs.Image")));
            this.mmFileSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmFileSaveAs.Name = "mmFileSaveAs";
            this.mmFileSaveAs.Size = new System.Drawing.Size(220, 38);
            this.mmFileSaveAs.Text = "Сохранить как";
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
            this.mmManageCategory.Size = new System.Drawing.Size(220, 38);
            this.mmManageCategory.Text = "Категории";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 6);
            // 
            // mmManageAdd
            // 
            this.mmManageAdd.Image = ((System.Drawing.Image)(resources.GetObject("mmManageAdd.Image")));
            this.mmManageAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageAdd.Name = "mmManageAdd";
            this.mmManageAdd.Size = new System.Drawing.Size(220, 38);
            this.mmManageAdd.Text = "Добавить предмет";
            // 
            // mmManageEdit
            // 
            this.mmManageEdit.Image = ((System.Drawing.Image)(resources.GetObject("mmManageEdit.Image")));
            this.mmManageEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageEdit.Name = "mmManageEdit";
            this.mmManageEdit.Size = new System.Drawing.Size(220, 38);
            this.mmManageEdit.Text = "Изменить предмет";
            // 
            // mmManageToTrash
            // 
            this.mmManageToTrash.Image = ((System.Drawing.Image)(resources.GetObject("mmManageToTrash.Image")));
            this.mmManageToTrash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageToTrash.Name = "mmManageToTrash";
            this.mmManageToTrash.Size = new System.Drawing.Size(220, 38);
            this.mmManageToTrash.Text = "Выбросить в корзину";
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
            this.mmHelpAbout.Size = new System.Drawing.Size(196, 38);
            this.mmHelpAbout.Text = "О программе";
            // 
            // panelForGb
            // 
            this.panelForGb.Controls.Add(this.gbFilter);
            this.panelForGb.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelForGb.Location = new System.Drawing.Point(591, 25);
            this.panelForGb.Name = "panelForGb";
            this.panelForGb.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.panelForGb.Size = new System.Drawing.Size(233, 392);
            this.panelForGb.TabIndex = 4;
            this.panelForGb.Visible = false;
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
            this.gbFilter.Size = new System.Drawing.Size(221, 386);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
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
            this.mmViewFilter.Image = ((System.Drawing.Image)(resources.GetObject("mmViewFilter.Image")));
            this.mmViewFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmViewFilter.Name = "mmViewFilter";
            this.mmViewFilter.Size = new System.Drawing.Size(196, 38);
            this.mmViewFilter.Text = "Фильтр";
            // 
            // tsbutCreateNew
            // 
            this.tsbutCreateNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbutCreateNew.Image")));
            this.tsbutCreateNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutCreateNew.Name = "tsbutCreateNew";
            this.tsbutCreateNew.Size = new System.Drawing.Size(23, 22);
            this.tsbutCreateNew.Text = "Создать новый склад";
            // 
            // tsbutOpen
            // 
            this.tsbutOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbutOpen.Image")));
            this.tsbutOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutOpen.Name = "tsbutOpen";
            this.tsbutOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbutOpen.Text = "Открыть существующий склад";
            // 
            // tsbutSave
            // 
            this.tsbutSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbutSave.Image")));
            this.tsbutSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutSave.Name = "tsbutSave";
            this.tsbutSave.Size = new System.Drawing.Size(23, 22);
            this.tsbutSave.Text = "Сохранить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbutManageCategory
            // 
            this.tsbutManageCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutManageCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbutManageCategory.Image")));
            this.tsbutManageCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutManageCategory.Name = "tsbutManageCategory";
            this.tsbutManageCategory.Size = new System.Drawing.Size(23, 22);
            this.tsbutManageCategory.Text = "Управление категориями";
            // 
            // tsbutAdd
            // 
            this.tsbutAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbutAdd.Image")));
            this.tsbutAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutAdd.Name = "tsbutAdd";
            this.tsbutAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbutAdd.Text = "Добавить предмет";
            // 
            // tsbutEdit
            // 
            this.tsbutEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbutEdit.Image")));
            this.tsbutEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutEdit.Name = "tsbutEdit";
            this.tsbutEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbutEdit.Text = "Изменить информацию о предмете";
            // 
            // tsbutToTrash
            // 
            this.tsbutToTrash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutToTrash.Image = ((System.Drawing.Image)(resources.GetObject("tsbutToTrash.Image")));
            this.tsbutToTrash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutToTrash.Name = "tsbutToTrash";
            this.tsbutToTrash.Size = new System.Drawing.Size(23, 22);
            this.tsbutToTrash.Text = "Выбросить в корзину";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbutAbout
            // 
            this.tsbutAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbutAbout.Image")));
            this.tsbutAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutAbout.Name = "tsbutAbout";
            this.tsbutAbout.Size = new System.Drawing.Size(23, 22);
            this.tsbutAbout.Text = "О программе";
            // 
            // tstbQuickSearch
            // 
            this.tstbQuickSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbQuickSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstbQuickSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbQuickSearch.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.tstbQuickSearch.Name = "tstbQuickSearch";
            this.tstbQuickSearch.Size = new System.Drawing.Size(200, 25);
            // 
            // tslQuickSearch
            // 
            this.tslQuickSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslQuickSearch.Name = "tslQuickSearch";
            this.tslQuickSearch.Size = new System.Drawing.Size(100, 22);
            this.tslQuickSearch.Text = "Быстрый поиск:";
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAll.Location = new System.Drawing.Point(3, 3);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.Size = new System.Drawing.Size(577, 333);
            this.dgvAll.TabIndex = 0;
            // 
            // dgvSoon
            // 
            this.dgvSoon.AllowUserToAddRows = false;
            this.dgvSoon.AllowUserToDeleteRows = false;
            this.dgvSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoon.Location = new System.Drawing.Point(3, 3);
            this.dgvSoon.Name = "dgvSoon";
            this.dgvSoon.ReadOnly = true;
            this.dgvSoon.Size = new System.Drawing.Size(577, 333);
            this.dgvSoon.TabIndex = 0;
            // 
            // dgvTrash
            // 
            this.dgvTrash.AllowUserToAddRows = false;
            this.dgvTrash.AllowUserToDeleteRows = false;
            this.dgvTrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrash.Location = new System.Drawing.Point(3, 3);
            this.dgvTrash.Name = "dgvTrash";
            this.dgvTrash.ReadOnly = true;
            this.dgvTrash.Size = new System.Drawing.Size(577, 333);
            this.dgvTrash.TabIndex = 0;
            // 
            // tpOverdue
            // 
            this.tpOverdue.Controls.Add(this.dgvOverdue);
            this.tpOverdue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpOverdue.Location = new System.Drawing.Point(4, 24);
            this.tpOverdue.Name = "tpOverdue";
            this.tpOverdue.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverdue.Size = new System.Drawing.Size(583, 339);
            this.tpOverdue.TabIndex = 4;
            this.tpOverdue.Text = "Просрочка";
            this.tpOverdue.UseVisualStyleBackColor = true;
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverdue.Location = new System.Drawing.Point(3, 3);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.Size = new System.Drawing.Size(577, 333);
            this.dgvOverdue.TabIndex = 0;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // tbFilterName
            // 
            this.tbFilterName.Location = new System.Drawing.Point(6, 35);
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.Size = new System.Drawing.Size(209, 21);
            this.tbFilterName.TabIndex = 1;
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
            // cbFilterCategory
            // 
            this.cbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCategory.FormattingEnabled = true;
            this.cbFilterCategory.Location = new System.Drawing.Point(6, 77);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(209, 23);
            this.cbFilterCategory.TabIndex = 3;
            // 
            // dtpDateCreateOT
            // 
            this.dtpDateCreateOT.Location = new System.Drawing.Point(35, 173);
            this.dtpDateCreateOT.Name = "dtpDateCreateOT";
            this.dtpDateCreateOT.Size = new System.Drawing.Size(180, 21);
            this.dtpDateCreateOT.TabIndex = 5;
            // 
            // checkDateCreate
            // 
            this.checkDateCreate.AutoSize = true;
            this.checkDateCreate.Location = new System.Drawing.Point(6, 148);
            this.checkDateCreate.Name = "checkDateCreate";
            this.checkDateCreate.Size = new System.Drawing.Size(157, 19);
            this.checkDateCreate.TabIndex = 8;
            this.checkDateCreate.Text = "По дате изготовления";
            this.checkDateCreate.UseVisualStyleBackColor = true;
            // 
            // dtpDateCreateDO
            // 
            this.dtpDateCreateDO.Location = new System.Drawing.Point(35, 200);
            this.dtpDateCreateDO.Name = "dtpDateCreateDO";
            this.dtpDateCreateDO.Size = new System.Drawing.Size(180, 21);
            this.dtpDateCreateDO.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "До:";
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
            this.dtpDateToTrashDO.Location = new System.Drawing.Point(35, 279);
            this.dtpDateToTrashDO.Name = "dtpDateToTrashDO";
            this.dtpDateToTrashDO.Size = new System.Drawing.Size(180, 21);
            this.dtpDateToTrashDO.TabIndex = 15;
            // 
            // checkDateToTrash
            // 
            this.checkDateToTrash.AutoSize = true;
            this.checkDateToTrash.Location = new System.Drawing.Point(6, 227);
            this.checkDateToTrash.Name = "checkDateToTrash";
            this.checkDateToTrash.Size = new System.Drawing.Size(132, 19);
            this.checkDateToTrash.TabIndex = 14;
            this.checkDateToTrash.Text = "По сроку годности";
            this.checkDateToTrash.UseVisualStyleBackColor = true;
            // 
            // dtpDateToTrashOT
            // 
            this.dtpDateToTrashOT.Location = new System.Drawing.Point(35, 252);
            this.dtpDateToTrashOT.Name = "dtpDateToTrashOT";
            this.dtpDateToTrashOT.Size = new System.Drawing.Size(180, 21);
            this.dtpDateToTrashOT.TabIndex = 13;
            // 
            // tbFilterComment
            // 
            this.tbFilterComment.Location = new System.Drawing.Point(6, 121);
            this.tbFilterComment.Name = "tbFilterComment";
            this.tbFilterComment.Size = new System.Drawing.Size(209, 21);
            this.tbFilterComment.TabIndex = 19;
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
            // butFilterApply
            // 
            this.butFilterApply.Location = new System.Drawing.Point(6, 306);
            this.butFilterApply.Name = "butFilterApply";
            this.butFilterApply.Size = new System.Drawing.Size(209, 23);
            this.butFilterApply.TabIndex = 20;
            this.butFilterApply.Text = "Применить фильтр";
            this.butFilterApply.UseVisualStyleBackColor = true;
            // 
            // butFilterReset
            // 
            this.butFilterReset.Location = new System.Drawing.Point(6, 335);
            this.butFilterReset.Name = "butFilterReset";
            this.butFilterReset.Size = new System.Drawing.Size(209, 23);
            this.butFilterReset.TabIndex = 21;
            this.butFilterReset.Text = "Сбросить фильтр";
            this.butFilterReset.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // mmManageExportToCSV
            // 
            this.mmManageExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("mmManageExportToCSV.Image")));
            this.mmManageExportToCSV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmManageExportToCSV.Name = "mmManageExportToCSV";
            this.mmManageExportToCSV.Size = new System.Drawing.Size(220, 38);
            this.mmManageExportToCSV.Text = "Экспорт в *.CSV";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Экспорт в *.CSV";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 439);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.panelForGb);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "АнтиПросрочка";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tpAll.ResumeLayout(false);
            this.tpSoon.ResumeLayout(false);
            this.tbTrash.ResumeLayout(false);
            this.panelForGb.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrash)).EndInit();
            this.tpOverdue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
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
        private System.Windows.Forms.ToolStripButton tsbutManageCategory;
        private System.Windows.Forms.ToolStripButton tsbutAdd;
        private System.Windows.Forms.ToolStripButton tsbutEdit;
        private System.Windows.Forms.ToolStripButton tsbutToTrash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbutAbout;
        private System.Windows.Forms.ToolStripTextBox tstbQuickSearch;
        private System.Windows.Forms.ToolStripLabel tslQuickSearch;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tpAll;
        private System.Windows.Forms.TabPage tpSoon;
        private System.Windows.Forms.TabPage tbTrash;
        private System.Windows.Forms.Panel panelForGb;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.DataGridView dgvSoon;
        private System.Windows.Forms.TabPage tpOverdue;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.DataGridView dgvTrash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

