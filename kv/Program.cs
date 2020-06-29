using System;
using System.Windows.Forms;

namespace kv
{
    static class Program
    {
        public static KvntEntities kv = new KvntEntities();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
        }
    }
}
