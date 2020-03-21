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
        /// Получить текущий список предметов
        /// </summary>
        public DataTable GetItemsAsDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Название предмета", typeof(string));
            dt.Columns.Add("Категория", typeof(string));
            dt.Columns.Add("Примечание", typeof(string));
            dt.Columns.Add("Дата изготовления", typeof(string));
            dt.Columns.Add("Годен ДО", typeof(string));

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                    dt.Rows.Add(i, list[i].Title, list[i].Category, list[i].Comment, list[i].DateOfCreate, list[i].DateToTrash);
            }

            return dt;
        }

        //public DataTable GetItemsAsDataTable(string findText)
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("ID", typeof(int));
        //    dt.Columns.Add("Название книги", typeof(string));
        //    dt.Columns.Add("Автор(ы)", typeof(string));
        //    dt.Columns.Add("Год", typeof(string));
        //    dt.Columns.Add("Жанр", typeof(string));
        //    dt.Columns.Add("Издательство", typeof(string));

        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i].Title.ToLower().Contains(findText.ToLower()) ||
        //                list[i].Author.ToLower().Contains(findText.ToLower()) ||
        //                list[i].Publisher.ToLower().Contains(findText.ToLower()) ||
        //                list[i].Style.ToLower().Contains(findText.ToLower()) ||
        //                list[i].Year.Contains(findText))
        //                dt.Rows.Add(i, list[i].Title, list[i].Author, list[i].Year, list[i].Style, list[i].Publisher);
        //        }
        //    }

        //    return dt;
        //}

        /// <summary>
        /// Добавление книги в список
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
        /// Удаление книги из списка по ее индексу
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

    }
}
