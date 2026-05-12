using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    public class CsvManager
    {
        public List<Employee> LoadEmployees(string filePath)
        {
            // checks if file exists, if not, creates it
            if (!File.Exists(filePath))
            {
                return new List<Employee>();
            }
            List<Employee> employees = new List<Employee>();
            string[] lines = File.ReadAllLines(filePath); // reads all of the lines and puts them in an array of strings

            for (int i = 1; i < lines.Length; i++) // skip first line as thats the header
            {
                string[] values = lines[i].Split(','); // associates values of each string in  the array  by splitting , 
                Employee e = new Employee(values[0], values[1], values[2], DateTime.Parse(values[3]), values[4], 
                    values[5], values[6], values[7], double.Parse(values[8]));
                e.HoursWorked = double.Parse(values[9]);
                e.PTODays = int.Parse(values[10]);
                employees.Add(e);
            }

            return employees;

        }

        public void SaveEmployees(string filePath, List<Employee> employees)
        {
            List<String> lines = new List<string>();
            lines.Add("FirstName,LastName,EmployeeId,DateOfBirth,Email,Password,Role,Department,HourlyRate,HoursWorked,PTODays");

            foreach (Employee e in employees) // everything gets converted back into the string, the opposite of LoadEmployees
            {
                string line = $"{e.FirstName},{e.LastName},{e.EmployeeId},{e.DateOfBirth.ToString("yyyy-MM-dd")},{e.Email},{e.Password},{e.Role},{e.Department},{e.HourlyRate},{e.HoursWorked},{e.PTODays}";
                lines.Add(line);   
            }

            File.WriteAllLines(filePath, lines);

        }

    }

    
}
