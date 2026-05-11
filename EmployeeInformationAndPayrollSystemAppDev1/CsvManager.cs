using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    internal class CsvManager
    {
        public List<Employee> LoadEmployees(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Employee>();
            }
            List<Employee> employees = new List<Employee>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) 
            {
                string[] values = lines[i].Split(',');
                Employee e = new Employee(values[0], values[1], values[2], DateTime.Parse(values[3]), values[4], values[5], values[6], double.Parse(values[7]));
                employees.Add(e);
            }

            return employees;

        }

        public void SaveEmployees(string filePath, List<Employee> employees)
        {
            List<String> lines = new List<string>();
            lines.Add("FirstName,LastName,EmployeeId,DateOfBirth,Email,Role,Department,HourlyRate,HoursWorked,PTODays");

            foreach (Employee e in employees) 
            {
                string line = $"{e.FirstName},{e.LastName},{e.EmployeeId},{e.DateOfBirth.ToString("yyyy-MM-dd")},{e.Email},{e.Role},{e.Department},{e.HourlyRate},{e.HoursWorked},{e.PTODays}";
                lines.Add(line);   
            }

            File.WriteAllLines(filePath, lines);

        }

    }

    
}
