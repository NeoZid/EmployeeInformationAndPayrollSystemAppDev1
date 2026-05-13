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


            // creating the mdf file if it doesnt exist

            string dbPath = Application.StartupPath + "\\EIPS.mdf";
            if (!System.IO.File.Exists(dbPath))
            {
                try
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
                    using (System.Data.SqlClient.SqlConnection conn =
                        new System.Data.SqlClient.SqlConnection(connectionString))
                    {
                        conn.Open();
                        string createDb = $"CREATE DATABASE EIPS ON PRIMARY (NAME='EIPS', FILENAME='{dbPath}')";
                        System.Data.SqlClient.SqlCommand cmd =
                            new System.Data.SqlClient.SqlCommand(createDb, conn);
                        cmd.ExecuteNonQuery();
                    }
                } catch { }
            }



            // initialize the tables for the db on launch
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
