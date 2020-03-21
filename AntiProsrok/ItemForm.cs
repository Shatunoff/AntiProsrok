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
    }
}
