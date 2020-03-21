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
            switch (itemFormMode)
            {
                case ItemFormMode.Adding:
                    Text = "Добавить на склад";
                    butOk.Text = "Добавить на склад";
                    break;
                case ItemFormMode.Editing:
                    Text = "Изменить предмет";
                    butOk.Text = "Сохранить изменения";
                    break;
                default:
                    break;
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
    }
}
