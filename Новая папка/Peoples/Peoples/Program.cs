using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Peoples
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
        }

        static class DataBase // строка подключения к БД
        {
            public static string ConnectionString = @"Data Source=\\192.168.3.250\Veda\3 курс\ИСП 32-9\Никитин Шутов\МДК Приложение\Картинки\db.db; Integrated Security=False; MultipleActiveResultSets=True";
        }
        static class table_Peoples // описание таблиц из БД
        {
            public static string main = "Peoples";
            public static string ID = "ID";
            public static string Surname = "Surname";
            public static string Name = "Name";
            public static string Surname2 = "Surname2";

        }
        static class table_Photo
        {
            public static string main = "Photo";
            public static string ID = "ID";
            public static string Photo = "Photo";
        }


    }

}
