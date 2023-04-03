using LibraryManagementSystem2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Change this line after the test
            //Application.Run(new FrmMain());
            Application.Run(new MainForm());
            // Application.Run(new FrmBooks());
        }
    }
}
