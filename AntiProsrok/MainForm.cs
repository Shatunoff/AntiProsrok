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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Главное меню (MenuStrip)
        // Файл - Создать новый склад
        private void mmFileCreateNew_Click(object sender, EventArgs e)
        {

        }

        // Файл - Открыть существующий склад
        private void mmFileOpen_Click(object sender, EventArgs e)
        {

        }

        // Файл - Сохранить
        private void mmFileSave_Click(object sender, EventArgs e)
        {

        }

        // Файл - Сохранить как
        private void mmFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        // Файл - Выход из программы
        private void mmFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Вид - Показать/Спрятать Фильтр
        private void mmViewFilter_CheckStateChanged(object sender, EventArgs e)
        {
            panelForGb.Visible = mmViewFilter.Checked;
        }

        // Управление - Категории
        private void mmManageCategory_Click(object sender, EventArgs e)
        {

        }

        // Управление - Добавить предмет
        private void mmManageAdd_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }

        // Управление - Изменить информацию о предмете
        private void mmManageEdit_Click(object sender, EventArgs e)
        {

        }

        // Управление - Выбросить в корзину
        private void mmManageToTrash_Click(object sender, EventArgs e)
        {

        }

        // Управление - Экспорт в *.CSV
        private void mmManageExportToCSV_Click(object sender, EventArgs e)
        {

        }

        // Справка - О программе
        private void mmHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
        #endregion

        private void checkDateCreate_CheckStateChanged(object sender, EventArgs e)
        {
            dtpDateCreateOT.Enabled = dtpDateCreateDO.Enabled = checkDateCreate.Checked;
        }

        private void checkDateToTrash_CheckStateChanged(object sender, EventArgs e)
        {
            dtpDateToTrashOT.Enabled = dtpDateToTrashDO.Enabled = checkDateToTrash.Checked;
        }
    }
}
