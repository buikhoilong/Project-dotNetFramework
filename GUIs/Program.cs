using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formDangNhap());
        }

        //public static string imgPath = @"D:\HK4\Programming C WinForm\432_434_cdth19e1\img\";
        public static string imgPath = @"C:\Users\Admin\Desktop\432_434_cdth19e1\img\";
    }
}
