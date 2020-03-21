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
        string fileName = null;
        Items items;

        public MainForm()
        {
            InitializeComponent();
            items = new Items();
            tslDateTime.Text = DateTime.Now.ToString();
            timerTime.Start();
            cbFilterCategory.Items.Clear();
            cbFilterCategory.Items.Add("");
            cbFilterCategory.Items.AddRange(Category.GetCategories().ToArray());
        }

        #region Методы для работы с предметами
        /// <summary>
        /// Просьба подтвердить действие
        /// </summary>
        /// <param name="boxTitle">Подпись диалогового окна.</param>
        /// <param name="boxMessage">Сообщение пользователю.</param>
        private bool AreYouReady(string boxMessage, string boxTitle)
        {
            if (MessageBox.Show(boxMessage, boxTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }

        /// <summary>
        /// Получить индекс из столбца ID выделенной строки активной таблицы
        /// </summary>
        private int GetIndexFromActiveDgv()
        {
            // TODO: Получить индекс из столбца ID выделенной строки активной таблицы
            return -1;
        }

        /// <summary>
        /// Обновить источник таблицы
        /// </summary>
        private void RefreshTable()
        {
            dgvAll.DataSource = items.GetItemsAsDataTable();
            //TODO: Обновлять все таблицы в этом методе
        }
        #endregion

        #region Главное меню (MenuStrip)
        // Файл - Создать новый склад
        private void mmFileCreateNew_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                if (AreYouReady("Несохранённые изменения будут утеряны.", "Создать новый склад?"))
                    items = new Items();
            }
            else items = new Items();
        }

        // Файл - Открыть существующий склад
        private void mmFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Открыть существующий склад";
            openFile.Filter = "XML-Файлы | *.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                items.Load(openFile.FileName);
                fileName = openFile.FileName;
                RefreshTable();
            }
        }

        // Файл - Сохранить
        private void mmFileSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileName))
                items.Save(fileName);
            else mmFileSaveAs.PerformClick();
        }

        // Файл - Сохранить как
        private void mmFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Сохранение склада";
            saveFile.Filter = "XML-Файлы | *.xml";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                items.Save(saveFile.FileName);
                fileName = saveFile.FileName;
            }
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
            CategoryList catList = new CategoryList();
            if(catList.ShowDialog() == DialogResult.OK)
            {
                cbFilterCategory.Items.Clear();
                cbFilterCategory.Items.Add("");
                cbFilterCategory.Items.AddRange(Category.GetCategories().ToArray());
            }
        }

        // Управление - Добавить предмет
        private void mmManageAdd_Click(object sender, EventArgs e)
        {
            ItemForm add = new ItemForm(ItemForm.ItemFormMode.Adding);
            add.cbItemCategory.Items.AddRange(Category.GetCategories().ToArray());
            if (add.ShowDialog() == DialogResult.OK)
            {
                Item item = new Item();
                item.Title = add.tbItemName.Text;
                item.Category = add.cbItemCategory.Text;
                item.Comment = add.tbItemComment.Text;
                item.DateOfCreate = add.dtpDateCreate.Value.ToShortDateString();
                item.DateToTrash = add.dtpDateToTrash.Value.ToShortDateString();
                items.Add(item);
                RefreshTable();
            }
        }

        // Управление - Изменить информацию о предмете
        private void mmManageEdit_Click(object sender, EventArgs e)
        {
            int activeIndex = GetIndexFromActiveDgv(); // Получаем индекс выделенной строки активной таблицы
            if (activeIndex >= 0)
            {
                ItemForm edit = new ItemForm(ItemForm.ItemFormMode.Editing);
                edit.cbItemCategory.Items.AddRange(Category.GetCategories().ToArray());
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item();
                    item.Title = edit.tbItemName.Text;
                    item.Category = edit.cbItemCategory.Text;
                    item.Comment = edit.tbItemComment.Text;
                    item.DateOfCreate = edit.dtpDateCreate.Value.ToShortDateString();
                    item.DateToTrash = edit.dtpDateToTrash.Value.ToShortDateString();
                    items.ChangeBookAt(activeIndex, item);
                    RefreshTable();
                }
            }
        }

        // Управление - Выбросить в корзину
        private void mmManageToTrash_Click(object sender, EventArgs e)
        {
            int activeIndex = GetIndexFromActiveDgv(); // Получаем индекс выделенной строки активной таблицы
            if (AreYouReady("Данное действие необратимо. Вы уверены?", "Удаление предмета"))
            {
                items.RemoveAt(activeIndex);
                RefreshTable();
            }
        }

        // Управление - Экспорт в *.CSV
        private void mmManageExportToCSV_Click(object sender, EventArgs e)
        {
            // TODO: Управление - Экспорт в *.CSV
        }

        // Справка - О программе
        private void mmHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
        #endregion

        #region Фильтр
        private void checkDateCreate_CheckStateChanged(object sender, EventArgs e)
        {
            dtpDateCreateOT.Enabled = dtpDateCreateDO.Enabled = checkDateCreate.Checked;
        }

        private void checkDateToTrash_CheckStateChanged(object sender, EventArgs e)
        {
            dtpDateToTrashOT.Enabled = dtpDateToTrashDO.Enabled = checkDateToTrash.Checked;
        }

        private void butFilterApply_Click(object sender, EventArgs e)
        {
            // TODO: Применить фильтр
        }

        private void butFilterReset_Click(object sender, EventArgs e)
        {
            // TODO: Сбросить фильтр
        }
        #endregion

        private void timerTime_Tick(object sender, EventArgs e)
        {
            tslDateTime.Text = DateTime.Now.ToString();
        }

    }
}
