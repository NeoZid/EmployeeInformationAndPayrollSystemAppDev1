using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmployeeId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public int PTODays { get; set; }

        public Employee (string firstName, string lastName, string employeeId, DateTime dateOfBirth, string email, string password, string role, string department,
            double  hourlyRate)
        {
            this.FirstName = firstName ;
            this.LastName = lastName ;
            this.EmployeeId = employeeId ;
            this.DateOfBirth = dateOfBirth ;
            this.Email = email ;
            this.Password = password ;
            this.Role = role ;
            this.Department = department ;
            this.HourlyRate = hourlyRate;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        


    }
}
