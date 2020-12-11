using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad3
{
    static class Program
    {
        public static int EmployeeId = 0; 
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            if (EmployeeId > 0)
            {
                Application.Run(new FromMain());
            }
        }
    }
}
