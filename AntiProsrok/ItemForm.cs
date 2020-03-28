using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiProsrok
{
    public partial class ItemForm : Form
    {
        public string ItemName
        {
            get
            {
                return tbItemName.Text;
            }
            set
            {
                tbItemName.Text = value;
            }
        }

        public string ItemCategory
        {
            get
            {
                return cbItemCategory.Text;
            }
            set
            {
                cbItemCategory.SelectedItem = value;
            }
        }

        public string ItemComment
        {
            get
            {
                return tbItemComment.Text;
            }
            set
            {
                tbItemComment.Text = value;
            }
        }

        public string ItemDateOfCreate
        {
            get
            {
                return dtpDateCreate.Value.ToShortDateString();
            }
            set
            {
                dtpDateCreate.Text = value;
            }
        }

        public string ItemDateToTrash
        {
            get
            {
                return dtpDateToTrash.Value.ToShortDateString();
            }
            set
            {
                dtpDateToTrash.Text = value;
            }
        }

        public ItemForm()
        {
            InitializeComponent();
        }

        public enum ItemFormMode
        {
            Adding, Editing
        }

        public ItemForm(ItemFormMode itemFormMode)
        {
            InitializeComponent();
            cbItemCategory.Items.AddRange(Category.GetCategories().ToArray());
            switch (itemFormMode)
            {
                case ItemFormMode.Adding:
                    Text = "Добавить на склад";
                    butOk.Text = "Добавить на склад";
                    cbItemCategory.SelectedIndex = 0;
                    break;
                case ItemFormMode.Editing:
                    Text = "Изменить предмет";
                    butOk.Text = "Сохранить изменения";
                    break;
                default:
                    break;
            }

            if (itemFormMode == ItemFormMode.Editing)
            {
                if (ItemDateToTrash != dtpDateToTrash.MaxDate.ToShortDateString())
                    checkDateToTrash.Checked = false;
            }
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            // Проверки валидности дат
            if (dtpDateCreate.Value > DateTime.Now)
            {
                MessageBox.Show("Дата изготовления предмета не может быть позже текущей даты.",
                    "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpDateCreate.Value > dtpDateToTrash.Value)
            {
                MessageBox.Show("Дата окончания срока годности не может наступать раньше даты изготовления.",
                    "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DialogResult = DialogResult.OK;
        }

        private void checkDateToTrash_CheckStateChanged(object sender, EventArgs e)
        {
            dtpDateToTrash.Value = dtpDateToTrash.MaxDate;
            dtpDateToTrash.Enabled = checkDateToTrash.Checked;
        }
    }
}
