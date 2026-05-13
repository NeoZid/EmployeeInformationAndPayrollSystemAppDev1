using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationAndPayrollSystemAppDev1
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

            // initialize the db on launch
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.InitializeDatabase();
            }
            catch 
            {
                Console.WriteLine("Database connection failed");
            }

            Application.Run(new LogInForm());
        }
    }
}
