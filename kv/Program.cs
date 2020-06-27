using System;
using System.Windows.Forms;

namespace kv
{
    static class Program
    {
        public static KvntEntities2 kv = new KvntEntities2();
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
