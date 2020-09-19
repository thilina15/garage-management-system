using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
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
           Application.Run(new startPage());
            //Application.Run(new report());
            //Application.Run(new adminPage());
            //Application.Run(new mechanistPage());
            //Application.Run(new addingSpareParts());
            //Application.Run(new jobDetails());
            //Application.Run(new startPage());E:\MIT_Web_gitHub\garage-management-system\Program.cs

        }
    }
}
