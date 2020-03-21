using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AntiProsrok
{
    public static class Category
    {
        // Получить категории из файла
        public static List<string> GetCategories()
        {
            List<string> list = new List<string>();
            FileStream fs = null;
            StreamReader sr = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("categories.ini", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream)
                    list.Add(sr.ReadLine());
            }
            catch(FileNotFoundException) // Если файл куда-то делся
            {
                fs = new FileStream("categories.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                sw.WriteLine("Без категории");
                sw.Close();
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                    list.Add(sr.ReadLine());
            }
            finally
            {
                sr?.Close();
                fs?.Close();
            }
            return list;
        }

        // Записать категории в файл
        public static void SaveCategories(List<string> list)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream("categories.ini", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (string item in list)
                    sw.WriteLine(item);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sw?.Close();
                fs?.Close();
            }
        }
    }
}
