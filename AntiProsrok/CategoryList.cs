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
    public partial class CategoryList : Form
    {
        private List<string> listCat = new List<string>();

        public CategoryList()
        {
            InitializeComponent();

            foreach (string item in Category.GetCategories())
                lbCategoryList.Items.Add(item);
        }
        
        private void butCategoryAdd_Click(object sender, EventArgs e)
        {
            if (!lbCategoryList.Items.Contains(tbCategoryName.Text))
                lbCategoryList.Items.Add(tbCategoryName.Text);
            else MessageBox.Show("Такая категория уже есть!", "Ошибка добавления");
        }

        private void butCategoryRemove_Click(object sender, EventArgs e)
        {
            lbCategoryList.Items.RemoveAt(lbCategoryList.SelectedIndex);
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            foreach (string item in lbCategoryList.Items)
                listCat.Add(item);
            Category.SaveCategories(listCat);
        }
    }
}
