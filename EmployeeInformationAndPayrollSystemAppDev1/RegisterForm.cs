using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    public partial class RegisterForm : Form
    {
        private ManagerForm _managerForm;
        
        public RegisterForm(ManagerForm managerForm)
        {
            InitializeComponent();
            _managerForm = managerForm;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CsvManager csv = new CsvManager();
            string path = Application.StartupPath + "\\employees.csv";
            List<Employee> employees = csv.LoadEmployees(path);

            int maxNumber = 0;
            foreach (Employee emp in employees) 
            {
                int num = int.Parse(emp.EmployeeId.Replace("EMP",""));
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            
            employeeIdTb.Text = "EMP" + (maxNumber + 1).ToString("D3");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // load employees first to check duplicates
            CsvManager csv = new CsvManager();
            string path = Application.StartupPath + "\\employees.csv"; // always points to bin/Debug
            List<Employee> employees = csv.LoadEmployees(path);


            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; 
            // allowed characters before @, valid domain format and atleast 2 letter domain extension ex: .com/.ca/.org

            // validate empty spaces
            if (string.IsNullOrWhiteSpace(fNameTb.Text) || string.IsNullOrWhiteSpace(lNameTb.Text) || string.IsNullOrWhiteSpace(emailTb.Text) || 
                string.IsNullOrWhiteSpace(passwordTb.Text) ||
                string.IsNullOrWhiteSpace(hourlyRateTb.Text) || roleCb.SelectedIndex == -1 || departmentCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate first name,lname = letters, and allowed spaced last names and hypens
            if (!fNameTb.Text.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
            {
                MessageBox.Show("First name can only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string firstName = fNameTb.Text;

            if (!lNameTb.Text.All(c => char.IsLetter(c) || c == ' ' || c == '-')) 
            {
                MessageBox.Show("Last name can only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string lastName = lNameTb.Text;

            // validate email
            if (!Regex.IsMatch(emailTb.Text, emailRegex))
            {
                MessageBox.Show("Email must have @, valid domain format and atleast 2 letter domain extension", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // validate same email
            if(employees.Any(emp => emp.Email == emailTb.Text))
            {
                MessageBox.Show("An employee with this email already exists!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string email = emailTb.Text;

            // validate password, must be atleast 6 characters
            if (passwordTb.Text.Length < 6) 
            {
                MessageBox.Show("Password must atleast be 6 or more characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string password = passwordTb.Text;

            // validate bday, cant be in the future or too old
            if (bdayTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date birth cannot be in the future", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bdayTimePicker.Value < DateTime.Now.AddYears(-100))
            {
                MessageBox.Show("Enter a valid date of birth", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime birthDay = bdayTimePicker.Value;

            string employeeId = employeeIdTb.Text;
            string department = departmentCb.Text;
            string role = roleCb.Text;

            //hourly rate validation
            if (!Regex.IsMatch(hourlyRateTb.Text, @"^\d+(\.\d{1,2})?$")) // whole number, decimal
            {
                MessageBox.Show("Hourly Rate must be a valid number. Example: 25 or 25.50", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double.TryParse(hourlyRateTb.Text, out double hourlyRate);
            if (hourlyRate <= 0)
            {
                MessageBox.Show("Hourly Rate must be greater than 0!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hourlyRate > 500)
            {
                MessageBox.Show("Hourly Rate cannot exceed 500$ per hour!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            
            Employee employee1 = new Employee(firstName, lastName, employeeId, birthDay, email, password,role, department, hourlyRate);

            // For the csv
            employees.Add(employee1);
            csv.SaveEmployees(path, employees);

            // For the database
            try 
            {
                DatabaseManager db = new DatabaseManager();
                db.InsertEmployee(employee1);
            } catch
            {
                Console.WriteLine("There was a problem with the database connection, using CSV file");
            }
            

            MessageBox.Show("Employee Register successfully!" , "Success", MessageBoxButtons.OK , MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
