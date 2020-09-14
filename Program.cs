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
            //Application.Run(new startPage());
            //Application.Run(new adminPage());
<<<<<<< HEAD
            //Application.Run(new mechanistPage());
            Application.Run(new addingSpareParts());
=======
            Application.Run(new mechanistPage());
            
>>>>>>> af6a075e99790b5fcdaf0f5b000d4d1a6934226f
        }
    }
}
