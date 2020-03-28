using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace AntiProsrok
{
    public class Item
    {
        public string Title { get; set; } // Название предмета
        public string Category { get; set; } // Категория
        public string Comment { get; set; } // Примечание
        public string DateOfCreate { get; set; } // Дата изготовления
        public string DateToTrash { get; set; } // Дата, до которой предмет годен
    }

    public class Items
    {
        List<Item> list;

        /// <summary>
        /// Конструктор, создающий пустой список.
        /// </summary>
        public Items()
        {
            list = new List<Item>();
        }

        /// <summary>
        /// Индексатор для быстрого доступа
        /// </summary>
        public Item this[int index]
        {
            get
            {
                if (list.Count >= index)
                    return list[index];
                return list[0];
            }
        }

        /// <summary>
        /// Создание общей для всех DataGridView-методов таблицы.
        /// </summary>
        /// <returns></returns>
        private DataTable dtCreate()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Название предмета", typeof(string));
            dt.Columns.Add("Категория", typeof(string));
            dt.Columns.Add("Примечание", typeof(string));
            dt.Columns.Add("Дата изготовления", typeof(DateTime));
            dt.Columns.Add("Годен ДО", typeof(DateTime));
            return dt;
        }

        /// <summary>
        /// Получить текущий список всех предметов
        /// </summary>
        public DataTable GetAllItemsAsDataTable()
        {
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                    dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment, list[i].DateOfCreate, list[i].DateToTrash);
            }

            return dt;
        }

        /// <summary>
        /// Получить список всех предметов на складе по указанному фильтру
        /// </summary>
        /// <param name="TitleFilter">Должно содержать название</param>
        /// <param name="CatFilter">Должна содержать категория</param>
        /// <param name="CommentFilter">Должно содержать примечание</param>
        /// <param name="DateOfCreateFilterOT">Период даты изготовления ОТ</param>
        /// <param name="DateOfCreateFilterDO">Период даты изготовления ДО</param>
        /// <param name="DateToTrashFilterOT">Период "Годен ДО" ОТ</param>
        /// <param name="DateToTrashFilterDO">Период "Годен ДО" ДО</param>
        public DataTable GetAllItemsAsDataTable(string TitleFilter, string CatFilter, string CommentFilter,
            DateTime DateOfCreateFilterOT, DateTime DateOfCreateFilterDO, 
            DateTime DateToTrashFilterOT, DateTime DateToTrashFilterDO)
        {
            if (TitleFilter == null) TitleFilter = string.Empty;
            if (CatFilter == null) CatFilter = string.Empty;
            if (CommentFilter == null) CommentFilter = string.Empty;

            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string title = list[i].Title;
                    string category = list[i].Category;
                    string comment = list[i].Comment;
                    DateTime datecreate = DateTime.Parse(list[i].DateOfCreate);
                    DateTime datetrash = DateTime.Parse(list[i].DateToTrash);

                    if (title.ToLower().Contains(TitleFilter.ToLower()) &&
                        category.ToLower().Contains(CatFilter.ToLower()) &&
                        comment.ToLower().Contains(CommentFilter.ToLower()) &&
                        (datecreate >= DateOfCreateFilterOT && datecreate <= DateOfCreateFilterDO) &&
                        (datetrash >= DateToTrashFilterOT && datetrash <= DateToTrashFilterDO))
                    {
                        dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment, list[i].DateOfCreate, list[i].DateToTrash);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Получить список предметов, срок годности которых заканчивается больше чем через 7 дней.
        /// </summary>
        public DataTable GetIsOkayItemsAsDataTable()
        {
            DateTime dtTrash;
            TimeSpan dtime;
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dtTrash = DateTime.Parse(list[i].DateToTrash); // Годен ДО
                    if (dtTrash > DateTime.Now)
                    {
                        dtime = dtTrash - DateTime.Now;
                        if (dtime.Days > 7)
                        {
                            dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment,
                            list[i].DateOfCreate, list[i].DateToTrash);
                        }
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить список предметов по указанному фильтру, срок годности которых заканчивается больше чем через 7 дней.
        /// </summary>
        public DataTable GetIsOkayItemsAsDataTable(string TitleFilter, string CatFilter, string CommentFilter,
            DateTime DateOfCreateFilterOT, DateTime DateOfCreateFilterDO,
            DateTime DateToTrashFilterOT, DateTime DateToTrashFilterDO)
        {
            if (TitleFilter == null) TitleFilter = string.Empty;
            if (CatFilter == null) CatFilter = string.Empty;
            if (CommentFilter == null) CommentFilter = string.Empty;

            DateTime dtTrash;
            TimeSpan dtime;
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dtTrash = DateTime.Parse(list[i].DateToTrash); // Годен ДО
                    if (dtTrash > DateTime.Now)
                    {
                        dtime = dtTrash - DateTime.Now;
                        if (dtime.Days > 7)
                        {
                            string title = list[i].Title;
                            string category = list[i].Category;
                            string comment = list[i].Comment;
                            DateTime datecreate = DateTime.Parse(list[i].DateOfCreate);
                            DateTime datetrash = DateTime.Parse(list[i].DateToTrash);

                            if (title.ToLower().Contains(TitleFilter.ToLower()) &&
                                category.ToLower().Contains(CatFilter.ToLower()) &&
                                comment.ToLower().Contains(CommentFilter.ToLower()) &&
                                (datecreate >= DateOfCreateFilterOT && datecreate <= DateOfCreateFilterDO) &&
                                (datetrash >= DateToTrashFilterOT && datetrash <= DateToTrashFilterDO))
                            {
                                dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment,
                                list[i].DateOfCreate, list[i].DateToTrash);
                            }
                        }
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить список просрочки
        /// </summary>
        public DataTable GetIsOverdueItemsAsDataTable()
        {
            DateTime dtTrash;
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dtTrash = DateTime.Parse(list[i].DateToTrash); // Годен ДО
                    if (dtTrash < DateTime.Now)
                    {
                        dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment, 
                            list[i].DateOfCreate, list[i].DateToTrash);
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить список просрочки по фильтру
        /// </summary>
        public DataTable GetIsOverdueItemsAsDataTable(string TitleFilter, string CatFilter, string CommentFilter,
            DateTime DateOfCreateFilterOT, DateTime DateOfCreateFilterDO,
            DateTime DateToTrashFilterOT, DateTime DateToTrashFilterDO)
        {
            if (TitleFilter == null) TitleFilter = string.Empty;
            if (CatFilter == null) CatFilter = string.Empty;
            if (CommentFilter == null) CommentFilter = string.Empty;
            DateTime dtTrash;
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dtTrash = DateTime.Parse(list[i].DateToTrash); // Годен ДО
                    if (dtTrash < DateTime.Now)
                    {
                        string title = list[i].Title;
                        string category = list[i].Category;
                        string comment = list[i].Comment;
                        DateTime datecreate = DateTime.Parse(list[i].DateOfCreate);
                        DateTime datetrash = DateTime.Parse(list[i].DateToTrash);

                        if (title.ToLower().Contains(TitleFilter.ToLower()) &&
                            category.ToLower().Contains(CatFilter.ToLower()) &&
                            comment.ToLower().Contains(CommentFilter.ToLower()) &&
                            (datecreate >= DateOfCreateFilterOT && datecreate <= DateOfCreateFilterDO) &&
                            (datetrash >= DateToTrashFilterOT && datetrash <= DateToTrashFilterDO))
                        {
                            dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment, 
                                list[i].DateOfCreate, list[i].DateToTrash);
                        }
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить список предметов, срок годности которых заканчивается через 7 и менее дней.
        /// </summary>
        public DataTable GetIsSoonItemsAsDataTable()
        {
            DateTime dtTrash;
            TimeSpan dtime;
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dtTrash = DateTime.Parse(list[i].DateToTrash); // Годен ДО
                    if (dtTrash > DateTime.Now)
                    {
                        dtime = dtTrash - DateTime.Now;
                        if (dtime.Days <= 7)
                        {
                            dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment,
                            list[i].DateOfCreate, list[i].DateToTrash);
                        }
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить список предметов по указанному фильтру, срок годности которых заканчивается через 7 и менее дней.
        /// </summary>
        public DataTable GetIsSoonItemsAsDataTable(string TitleFilter, string CatFilter, string CommentFilter,
            DateTime DateOfCreateFilterOT, DateTime DateOfCreateFilterDO,
            DateTime DateToTrashFilterOT, DateTime DateToTrashFilterDO)
        {
            if (TitleFilter == null) TitleFilter = string.Empty;
            if (CatFilter == null) CatFilter = string.Empty;
            if (CommentFilter == null) CommentFilter = string.Empty;

            DateTime dtTrash;
            TimeSpan dtime;
            DataTable dt = dtCreate();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dtTrash = DateTime.Parse(list[i].DateToTrash); // Годен ДО
                    if (dtTrash > DateTime.Now)
                    {
                        dtime = dtTrash - DateTime.Now;
                        if (dtime.Days <= 7)
                        {
                            string title = list[i].Title;
                            string category = list[i].Category;
                            string comment = list[i].Comment;
                            DateTime datecreate = DateTime.Parse(list[i].DateOfCreate);
                            DateTime datetrash = DateTime.Parse(list[i].DateToTrash);

                            if (title.ToLower().Contains(TitleFilter.ToLower()) &&
                                category.ToLower().Contains(CatFilter.ToLower()) &&
                                comment.ToLower().Contains(CommentFilter.ToLower()) &&
                                (datecreate >= DateOfCreateFilterOT && datecreate <= DateOfCreateFilterDO) &&
                                (datetrash >= DateToTrashFilterOT && datetrash <= DateToTrashFilterDO))
                            {
                                dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment,
                                list[i].DateOfCreate, list[i].DateToTrash);
                            }
                        }
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Добавление предмета в список
        /// </summary>
        public void Add(Item item)
        {
            try
            {
                list.Add(item);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Экземпляр предмета не был передан.", "NullReferenceExceptioon",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаление предмета из списка по его индексу
        /// </summary>
        public void RemoveAt(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Индекс указанной книги находится за пределами диапазона.", "IndexOutRangeException",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновление информации о предмете по его индексу
        /// </summary>
        public void ChangeBookAt(int index, Item book)
        {
            try
            {
                list[index] = book;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Индекс указанной книги находится за пределами диапазона.", "IndexOutRangeException",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Экземпляр книги не был передан.", "NullReferenceExceptioon",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение склада в XML-файл.
        /// </summary>
        /// <param name="fileName">Путь к XML-файлу.</param>
        public void Save(string fileName)
        {
            FileStream fs = null;
            try
            {
                XmlSerializer xmlFile = new XmlSerializer(typeof(List<Item>)); // Создаем сериализатор
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write); // Создаем файловый поток
                xmlFile.Serialize(fs, list);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                fs?.Close();
            }
        }

        /// <summary>
        /// Загрузка склада из XML-файла.
        /// </summary>
        /// <param name="fileName">Путь к XML-файлу.</param>
        public void Load(string fileName)
        {
            FileStream fs = null; // Создаем файловый поток
            try
            {
                XmlSerializer xmlFile = new XmlSerializer(typeof(List<Item>)); // Создаем сериализатор
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Item>)xmlFile.Deserialize(fs);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                fs?.Close();
            }
        }

        /// <summary>
        /// Экспорт склада в CSV-файл по заданному пути.
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        public void ExportToCSV(string fileName)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                ToCSV.Export(fs, list);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                fs?.Close();
            }
        }
    }
}
