using System;
using System.Windows.Forms;

namespace kv
{
    static class Program
    {
        public static KvntEntities1 kv = new KvntEntities1();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
