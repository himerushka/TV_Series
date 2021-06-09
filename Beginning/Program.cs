using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beginning
{
    static class Data
    {
        public static int stat { get; set; }
        public static int series { get; set; }
        public static int rate { get; set; }
        public static string str1 { get; set; }
        public static string str2 { get; set; }
        public static string user { get; set; }
        public static string pass { get; set; }
        public static bool str2_v { get; set; }
        public static string UsersBtn { get; set; }
        public static bool without_error { get; set; }
        public static bool s_add { get; set; }
        public static bool s_ch { get; set; }
        public static bool s_del { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorization());
        }

    }
}
