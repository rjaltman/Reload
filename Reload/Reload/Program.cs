using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reload
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

            if (Properties.Settings.Default.uhOhItsThatDogeAgain == "")
            {
                Application.Run(new FirstRun());
            }
            else
            {
                Application.Run(new Form1());
            }
            

        }
    }
}
