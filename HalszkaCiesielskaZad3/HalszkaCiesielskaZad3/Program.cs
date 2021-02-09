using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad3
{
    static class Program
    {
        /// <summary>
        /// Variable to storage logged employee id.
        /// </summary>
        public static int EmployeeId = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Running form to login 
            Application.Run(new FormLogin());

            // Checking if there is employee with given login data in database 
            if (EmployeeId > 0)
            {
                // Running main form if user is logged
                Application.Run(new FromMain());
            }
        }
    }
}
