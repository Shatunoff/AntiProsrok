namespace AntiProsrok
{
    partial class AddItem
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.tbItemComment = new System.Windows.Forms.TextBox();
            this.lbComment = new System.Windows.Forms.Label();
            this.cbItemCategory = new System.Windows.Forms.ComboBox();
            this.lbDateCreate = new System.Windows.Forms.Label();
            this.dtpDateCreate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateToTrash = new System.Windows.Forms.DateTimePicker();
            this.lbDateToTrash = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.butCancel);
            this.gbMain.Controls.Add(this.butAdd);
            this.gbMain.Controls.Add(this.dtpDateToTrash);
            this.gbMain.Controls.Add(this.lbDateToTrash);
            this.gbMain.Controls.Add(this.dtpDateCreate);
            this.gbMain.Controls.Add(this.lbDateCreate);
            this.gbMain.Controls.Add(this.cbItemCategory);
            this.gbMain.Controls.Add(this.lbComment);
            this.gbMain.Controls.Add(this.tbItemComment);
            this.gbMain.Controls.Add(this.lbCategory);
            this.gbMain.Controls.Add(this.lbName);
            this.gbMain.Controls.Add(this.tbItemName);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(10, 5);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(247, 294);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Укажите характеристики";
            // 
            // tbItemName
            // 
            this.tbItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemName.Location = new System.Drawing.Point(6, 35);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(235, 21);
            this.tbItemName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 15);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Название:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(6, 59);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(72, 15);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Категория:";
            // 
            // tbItemComment
            // 
            this.tbItemComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemComment.Location = new System.Drawing.Point(6, 121);
            this.tbItemComment.Name = "tbItemComment";
            this.tbItemComment.Size = new System.Drawing.Size(235, 21);
            this.tbItemComment.TabIndex = 2;
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(6, 103);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(83, 15);
            this.lbComment.TabIndex = 4;
            this.lbComment.Text = "Примечание:";
            // 
            // cbItemCategory
            // 
            this.cbItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemCategory.FormattingEnabled = true;
            this.cbItemCategory.Location = new System.Drawing.Point(6, 77);
            this.cbItemCategory.Name = "cbItemCategory";
            this.cbItemCategory.Size = new System.Drawing.Size(235, 23);
            this.cbItemCategory.TabIndex = 1;
            // 
            // lbDateCreate
            // 
            this.lbDateCreate.AutoSize = true;
            this.lbDateCreate.Location = new System.Drawing.Point(6, 145);
            this.lbDateCreate.Name = "lbDateCreate";
            this.lbDateCreate.Size = new System.Drawing.Size(124, 15);
            this.lbDateCreate.TabIndex = 6;
            this.lbDateCreate.Text = "Дата изготовления:";
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.Location = new System.Drawing.Point(6, 163);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(235, 21);
            this.dtpDateCreate.TabIndex = 3;
            // 
            // dtpDateToTrash
            // 
            this.dtpDateToTrash.Location = new System.Drawing.Point(6, 205);
            this.dtpDateToTrash.Name = "dtpDateToTrash";
            this.dtpDateToTrash.Size = new System.Drawing.Size(235, 21);
            this.dtpDateToTrash.TabIndex = 4;
            // 
            // lbDateToTrash
            // 
            this.lbDateToTrash.AutoSize = true;
            this.lbDateToTrash.Location = new System.Drawing.Point(6, 187);
            this.lbDateToTrash.Name = "lbDateToTrash";
            this.lbDateToTrash.Size = new System.Drawing.Size(66, 15);
            this.lbDateToTrash.TabIndex = 8;
            this.lbDateToTrash.Text = "Годен ДО:";
            // 
            // butAdd
            // 
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Location = new System.Drawing.Point(6, 232);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(235, 23);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "Добавить на склад";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(6, 261);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(235, 23);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 309);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить на склад";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.TextBox tbItemComment;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DateTimePicker dtpDateToTrash;
        private System.Windows.Forms.Label lbDateToTrash;
        private System.Windows.Forms.DateTimePicker dtpDateCreate;
        private System.Windows.Forms.Label lbDateCreate;
        private System.Windows.Forms.ComboBox cbItemCategory;
    }
}