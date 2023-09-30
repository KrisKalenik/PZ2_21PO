using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pz0429_Library.Helpers;
using Pz0429_Library.UIForms;

namespace Pz0429_Library
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
            //Application.Run(new frmLogin());
            Application.Run(new WordExample());

            /*if (UserCredentials.IsLoggedIn)
            {
                if (UserCredentials.Roles.Contains("Admin"))
                    Application.Run(new frmMainAdmin());
                //else Application.Run(new frmMainUser());
            }*/
        }
    }
}
