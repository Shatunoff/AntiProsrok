namespace AntiProsrok
{
    partial class CategoryList
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
            this.lbCategoryList = new System.Windows.Forms.ListBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.butCategoryEdit = new System.Windows.Forms.Button();
            this.butCategoryAdd = new System.Windows.Forms.Button();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCategoryName);
            this.groupBox1.Controls.Add(this.butCategoryAdd);
            this.groupBox1.Controls.Add(this.butCategoryEdit);
            this.groupBox1.Controls.Add(this.butOk);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.lbCategoryList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список категорий";
            // 
            // lbCategoryList
            // 
            this.lbCategoryList.FormattingEnabled = true;
            this.lbCategoryList.ItemHeight = 15;
            this.lbCategoryList.Location = new System.Drawing.Point(6, 88);
            this.lbCategoryList.Name = "lbCategoryList";
            this.lbCategoryList.Size = new System.Drawing.Size(235, 139);
            this.lbCategoryList.TabIndex = 0;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(6, 262);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(235, 23);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.Location = new System.Drawing.Point(6, 233);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(235, 23);
            this.butOk.TabIndex = 2;
            this.butOk.Text = "Сохранить категории";
            this.butOk.UseVisualStyleBackColor = true;
            // 
            // butCategoryEdit
            // 
            this.butCategoryEdit.Location = new System.Drawing.Point(129, 59);
            this.butCategoryEdit.Name = "butCategoryEdit";
            this.butCategoryEdit.Size = new System.Drawing.Size(112, 23);
            this.butCategoryEdit.TabIndex = 3;
            this.butCategoryEdit.Text = "Изменить";
            this.butCategoryEdit.UseVisualStyleBackColor = true;
            // 
            // butCategoryAdd
            // 
            this.butCategoryAdd.Location = new System.Drawing.Point(6, 59);
            this.butCategoryAdd.Name = "butCategoryAdd";
            this.butCategoryAdd.Size = new System.Drawing.Size(112, 23);
            this.butCategoryAdd.TabIndex = 4;
            this.butCategoryAdd.Text = "Добавить";
            this.butCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(6, 32);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(235, 21);
            this.tbCategoryName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название:";
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 309);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryList";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление категориями";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbCategoryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Button butCategoryAdd;
        private System.Windows.Forms.Button butCategoryEdit;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
    }
}