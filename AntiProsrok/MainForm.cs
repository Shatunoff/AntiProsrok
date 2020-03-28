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
        string fileName = null; //Для хранения пути к открытой/сохраненной базе
        Items items; // Для хранения содержимого БД

        public MainForm()
        {
            InitializeComponent();
            items = new Items();
            RefreshTable();
            tslDateTime.Text = DateTime.Now.ToString();
            timerTime.Start();
            cbFilterCategory.Items.Clear();
            cbFilterCategory.Items.Add(string.Empty);
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

        private DataGridView GetActiveDgv()
        {
            DataGridView dgv = null;
            foreach (var item in tabControlMain.SelectedTab.Controls)
            {
                if (item.GetType() == typeof(DataGridView))
                    dgv = (DataGridView)item;
            }
            return dgv;
        }

        private Item[] GetCheckItemsFromActiveDgv()
        {
            List<Item> listForRemove = new List<Item>();
            DataGridView dgv = GetActiveDgv();
            if (dgv != null)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j] is DataGridViewCheckBoxColumn)
                        {
                            if ((bool)dgv[j, i].EditedFormattedValue)
                            {
                                Item item = new Item();
                                for (int x = 0; x < dgv.Columns.Count; x++)
                                {
                                    if (dgv.Columns[x].HeaderText == items.ColIDHeaderText)
                                        item = items[Convert.ToInt32(dgv[x, i].Value)];
                                }
                                listForRemove.Add(item);
                            }
                        }
                    }
                }
            }
            return listForRemove.ToArray();
        }

        /// <summary>
        /// Получить индекс из столбца ID выделенной строки активной таблицы
        /// </summary>
        private int GetIndexFromActiveDgv()
        {
            // Ищем элемент DataGridView внутри активного TabPage
            DataGridView dgv = GetActiveDgv();
            // Если DataGridView найден и в нем выделена какая-то строка
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                return (int) dgv.SelectedRows[0].Cells[0].Value;
            }
            else
                return -1; // Возвращаем -1, если что-то пошло не так.
        }

        // Добавить столбец с чекбоксом
        private DataGridViewCheckBoxColumn AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn dgvCol = new DataGridViewCheckBoxColumn(); ;
            dgvCol.Name = "checkItem";
            dgvCol.HeaderText = "Выбрать";
            dgvCol.DisplayIndex = 0;
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCol.ReadOnly = false;
            dgvCol.TrueValue = 1;
            dgvCol.FalseValue = 0;
            return dgvCol;
        }

        // Оформление, применяемое к таблицам после обновления данных
        private void SetDgvStyle(ref DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
                col.ReadOnly = true;
            dgv.Columns[0].Visible = false;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.Columns.Add(AddCheckBoxColumn());
            
        }

        /// <summary>
        /// Обновить источник таблицы
        /// </summary>
        private void RefreshTable()
        {
            dgvAll.Columns.Clear();
            dgvIsOkay.Columns.Clear();
            dgvSoon.Columns.Clear();
            dgvOverdue.Columns.Clear();
            dgvAll.DataSource = items.GetAllItemsAsDataTable();
            SetDgvStyle(ref dgvAll);
            dgvIsOkay.DataSource = items.GetIsOkayItemsAsDataTable();
            SetDgvStyle(ref dgvIsOkay);
            dgvSoon.DataSource = items.GetIsSoonItemsAsDataTable();
            SetDgvStyle(ref dgvSoon);
            dgvOverdue.DataSource = items.GetIsOverdueItemsAsDataTable();
            SetDgvStyle(ref dgvOverdue);
        }

        #endregion

        #region Главное меню (MenuStrip)
        // Файл - Создать новый склад
        private void mmFileCreateNew_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                if (AreYouReady("Несохранённые изменения будут утеряны.", "Создать новый склад?"))
                {
                    items = new Items();
                    RefreshTable();
                }
            }
            else
            {
                items = new Items();
                RefreshTable();
            }
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
            {
                items.Save(fileName);
                PushTimerGo("Склад сохранен!");
            }
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
                PushTimerGo("Склад сохранен!");
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
                cbFilterCategory.Items.Add(string.Empty);
                cbFilterCategory.Items.AddRange(Category.GetCategories().ToArray());
            }
        }

        // Управление - Добавить предмет
        private void mmManageAdd_Click(object sender, EventArgs e)
        {
            ItemForm add = new ItemForm(ItemForm.ItemFormMode.Adding);
            add.cbItemCategory.Items.AddRange(Category.GetCategories().ToArray());
            add.cbItemCategory.SelectedIndex = 0;
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
            DataGridView dgv = GetActiveDgv();
            int activeIndex = GetIndexFromActiveDgv(); // Получаем индекс выделенной строки активной таблицы
            if (activeIndex >= 0)
            {
                ItemForm edit = new ItemForm(ItemForm.ItemFormMode.Editing);
                edit.cbItemCategory.Items.AddRange(Category.GetCategories().ToArray());
                edit.tbItemName.Text = (string)dgv.SelectedRows[0].Cells[1].Value;
                edit.cbItemCategory.SelectedItem = (string)dgv.SelectedRows[0].Cells[2].Value;
                edit.tbItemComment.Text = (string)dgv.SelectedRows[0].Cells[3].Value;
                edit.dtpDateCreate.Text = (string)dgv.SelectedRows[0].Cells[4].Value;
                edit.dtpDateToTrash.Text = (string)dgv.SelectedRows[0].Cells[5].Value;

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
            //Получить массив Items, отмеченных галочкой в активной таблице
            Item[] itemsForRemove = GetCheckItemsFromActiveDgv();
            //foreach (Item i in itemsForRemove)
            //{
            //    Console.WriteLine($"{i.Title}-{i.Category}-{i.Comment}-{i.DateOfCreate}-{i.DateToTrash}");
            //}

            if (itemsForRemove.Length > 0)
            {
                if (AreYouReady($"Вы уверены, что хотите удалить {itemsForRemove.Length} предмет(ов)?", "Удаление"))
                {
                    foreach (Item item in itemsForRemove)
                        items.Remove(item);
                    RefreshTable();
                }
            }
            else
            {
                MessageBox.Show("Отметьте предметы, которые хотите удалить, галочкой.", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
        }

        // Управление - Экспорт в *.CSV
        private void mmManageExportToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Экспорт склада в *.CSV";
            save.Filter = "CSV - файлы|*.csv";
            if (save.ShowDialog() == DialogResult.OK)
            {
                items.ExportToCSV(save.FileName);
                PushTimerGo("Экспорт успешно завершен!");
            }
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

        // Применить фильтр
        private void butFilterApply_Click(object sender, EventArgs e)
        {
            if ((checkDateCreate.Checked && dtpDateCreateOT.Value > dtpDateCreateDO.Value) || 
                (checkDateToTrash.Checked && dtpDateToTrashOT.Value > dtpDateToTrashDO.Value))
            {
                MessageBox.Show("Диапазон дат указан неверно!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO;
            if (checkDateCreate.Checked)
            {
                dtCreateOT = DateTime.Parse(dtpDateCreateOT.Value.ToShortDateString());
                dtCreateDO = DateTime.Parse(dtpDateCreateDO.Value.ToShortDateString());
            }
            else
            {
                dtCreateOT = DateTime.MinValue;
                dtCreateDO = DateTime.MaxValue;
            }

            if (checkDateToTrash.Checked)
            {
                dtTrashOT = DateTime.Parse(dtpDateToTrashOT.Value.ToShortDateString());
                dtTrashDO = DateTime.Parse(dtpDateToTrashDO.Value.ToShortDateString());
            }
            else
            {
                dtTrashOT = DateTime.MinValue;
                dtTrashDO = DateTime.MaxValue;
            }
            dgvAll.DataSource = items.GetAllItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
                tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            dgvIsOkay.DataSource = items.GetIsOkayItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
                tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            dgvSoon.DataSource = items.GetIsSoonItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
                tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            dgvOverdue.DataSource = items.GetIsOverdueItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
                tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            butFilterReset.Enabled = true;
        }

        // Сбросить фильтр
        private void butFilterReset_Click(object sender, EventArgs e)
        {
            butFilterReset.Enabled = false;
            tbFilterName.Text = string.Empty;
            cbFilterCategory.SelectedIndex = 0;
            dtpDateCreateOT.Value = DateTime.Now;
            dtpDateCreateDO.Value = DateTime.Now;
            dtpDateToTrashOT.Value = DateTime.Now;
            dtpDateToTrashDO.Value = DateTime.Now;
            tbFilterComment.Text = string.Empty;
            checkDateCreate.CheckState = CheckState.Unchecked;
            checkDateToTrash.CheckState = CheckState.Unchecked;
            RefreshTable();
        }
        #endregion

        #region Статусбар
        private void timerTime_Tick(object sender, EventArgs e)
        {
            tslDateTime.Text = DateTime.Now.ToString();
        }

        // Запуск таймера для отображения уведомления
        private void PushTimerGo(string message)
        {
            pushTimer.Start();
            statusSave.Text = message;
        }

        // Остановка таймера и стирание уведомления
        private void pushTimer_Tick(object sender, EventArgs e)
        {
            statusSave.Text = string.Empty;
            pushTimer.Stop();
        }
        #endregion
    }
}
