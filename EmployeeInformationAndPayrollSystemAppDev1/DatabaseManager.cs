using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    public class DatabaseManager
    {
        private string GetConnectionString()

        {
            string dbPath = Application.StartupPath + "\\EIPS.mdf";
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
        }

        public void InitializeDatabase()
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                string query = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U') 
                CREATE TABLE Employees
                (
                    EmployeeId   NVARCHAR(10)  NOT NULL PRIMARY KEY,
                    FirstName    NVARCHAR(50)  NOT NULL,
                    LastName     NVARCHAR(50)  NOT NULL,
                    DateOfBirth  DATE          NOT NULL,
                    Email        NVARCHAR(100) NOT NULL,
                    Password     NVARCHAR(50)  NOT NULL,
                    Role         NVARCHAR(50)  NOT NULL,
                    Department   NVARCHAR(50)  NOT NULL,
                    HourlyRate   FLOAT         NOT NULL,
                    HoursWorked  FLOAT         NOT NULL,
                    PTODays      INT           NOT NULL
                )";

                // Mental note:
                // sysbojects = SQL's internal table that lists all db objects
                // xtype='U' : U means User Table

                SqlCommand cmd = new SqlCommand(query, conn);   
                cmd.ExecuteNonQuery();
                
                    
            }
        }

        public void InsertEmployee(Employee emp)
        {
            // keyword: using automatically closes the connection.
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open(); // establishes the connection
                // we used @"" makes multiline string cleaner and readable
                string query = @"INSERT INTO Employees(EmployeeId, FirstName, LastName, DateOfBirth, Email, Password, Role,
                    Department, HourlyRate, HoursWorked, PTODays) VALUES (@EmployeeId, @FirstName, @LastName, @DateOfBirth, @Email, @Password,
                    @Role, @Department, @HourlyRate, @HoursWorked, @PTODays)";

                // SqlCommand is the bridge between C# code and Databases, acts as a translator
                SqlCommand cmd = new SqlCommand(query, conn);

                // using parameterized queries- used to protect db from SQL injection
                cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", emp.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@Role", emp.Role);
                cmd.Parameters.AddWithValue("@Department", emp.Department);
                cmd.Parameters.AddWithValue("@HourlyRate", emp.HourlyRate);
                cmd.Parameters.AddWithValue("@HoursWorked", emp.HoursWorked);
                cmd.Parameters.AddWithValue("@PTODays", emp.PTODays);

                cmd.ExecuteNonQuery(); // non query since it doesnt return data, just inserts
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                string query = @"UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, 
                        Email = @Email, Role = @Role, Department = @Department, HourlyRate = @HourlyRate, HoursWorked = @HoursWorked,
                        PTODays = @PTODays
                        WHERE EmployeeId = @EmployeeId";

                // SqlCommand is the bridge between C# code and Databases, acts as a translator
                SqlCommand cmd = new SqlCommand(query, conn);

                // using parameterized queries- used to protect db from SQL injection
                cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", emp.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Role", emp.Role);
                cmd.Parameters.AddWithValue("@Department", emp.Department);
                cmd.Parameters.AddWithValue("@HourlyRate", emp.HourlyRate);
                cmd.Parameters.AddWithValue("@HoursWorked", emp.HoursWorked);
                cmd.Parameters.AddWithValue("@PTODays", emp.PTODays);

                cmd.ExecuteNonQuery(); 
            }
        }

        public void DeleteEmployee(Employee emp)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                string query = @"DELETE FROM Employees WHERE EmployeeId = @EmployeeId";

                // SqlCommand is the bridge between C# code and Databases, acts as a translator
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmd.ExecuteNonQuery();
            }
        }

        public bool EmployeeExists(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employees WHERE EmployeeId = @EmployeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                int count = (int)cmd.ExecuteScalar(); // <- returns a single value of the query
                return count > 0; // 0 = false, 1+ = true
            }
        }

        public void SyncFromCsv(List<Employee> employees)
        {
            // loops through employees in CSV
            foreach (Employee emp in employees)
            {
                // if exists, inserts in the database // if not, skip
                if (!EmployeeExists(emp.EmployeeId))
                {
                    InsertEmployee(emp);
                }
            }
        }

    }

    
}
