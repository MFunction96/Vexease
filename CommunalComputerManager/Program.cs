using System;
using System.Windows.Forms;

namespace CommunalComputerManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Initial();
            Application.Run(new Adm());
        }
        /// <summary>
        /// 
        /// </summary>
        private static void Initial()
        {
            
        }
    }
}
