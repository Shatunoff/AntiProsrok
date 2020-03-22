using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AntiProsrok
{
    public static class ToCSV
    {
        public static void Export(FileStream fs, List<Item> list)
        {
            StreamWriter sw = null;
            try
            {
                string line = string.Empty;
                sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1251"));
                sw.WriteLine("Название предмета;Категория;Примечание;Дата изготовления;Годен ДО");
                foreach (var item in list)
                {
                    line = string.Join(";", item.Title, item.Category, item.Comment, item.DateOfCreate, item.DateToTrash);
                    sw.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sw?.Close();
            }
        }
    }
}
