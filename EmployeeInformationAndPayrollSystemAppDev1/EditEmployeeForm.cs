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
    public partial class EditEmployeeForm : Form
    {
        private Employee _employee;
        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            fNameTb.Text = _employee.FirstName;
            lNameTb.Text = _employee.LastName;
            emailTb.Text = _employee.Email;
            bdayTimePicker.Value = _employee.DateOfBirth;
            PTODaysTb.Text = _employee.PTODays.ToString();
            hoursWorkedTb.Text = _employee.HoursWorked.ToString();
            hourlyRateTb.Text = _employee.HourlyRate.ToString();
            departmentCb.SelectedItem = _employee.Department;
            roleCb.SelectedItem = _employee.Role;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // load employees first to check duplicates
            string path = Application.StartupPath + "\\employees.csv";
            CsvManager csv = new CsvManager();
            List<Employee> employees = csv.LoadEmployees(path);

            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; 
            // allowed characters before @, valid domain format and atleast 2 letter domain extension ex: .com/.ca/.org

            // validate empty spaces
            if (string.IsNullOrWhiteSpace(fNameTb.Text) || string.IsNullOrWhiteSpace(lNameTb.Text) || string.IsNullOrWhiteSpace(emailTb.Text)  
                || string.IsNullOrWhiteSpace(PTODaysTb.Text) || string.IsNullOrWhiteSpace(hoursWorkedTb.Text) ||
                string.IsNullOrWhiteSpace(hourlyRateTb.Text) || departmentCb.SelectedIndex == -1 || roleCb.SelectedIndex == -1)
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
            _employee.FirstName = fNameTb.Text;
            if (!lNameTb.Text.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
            {
                MessageBox.Show("Last name can only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _employee.LastName = lNameTb.Text;

            // validate email
            if (!Regex.IsMatch(emailTb.Text, emailRegex))
            {
                MessageBox.Show("Email must have @, valid domain format and atleast 2 letter domain extension", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // validate same email
            if (employees.Any(emp => emp.Email == emailTb.Text && emp.EmployeeId != _employee.EmployeeId))
            {
                MessageBox.Show("An employee with this email already exists!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _employee.Email = emailTb.Text;


            // validate bday, cant be in future or too old
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
            _employee.DateOfBirth = bdayTimePicker.Value;


            _employee.Department = departmentCb.Text;
            _employee.Role = roleCb.Text;

            // validate hourlyRate, should only be numbers / greater than 0 / accept only digits/single period // 25.50
            if (!Regex.IsMatch(hourlyRateTb.Text, @"^\d+(\.\d{1,2})?$"))
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
            _employee.HourlyRate = hourlyRate;


            // validate hours worked, must be a number
            if (!Regex.IsMatch(hoursWorkedTb.Text, @"^\d+(\.\d+)?$"))
            {
                MessageBox.Show("Hours Worked must be a valid number. Example: 40 or 37.5", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double.TryParse(hoursWorkedTb.Text, out double hoursWorked);
            // between 0 and 80 only
            if (hoursWorked > 80)
            {
                MessageBox.Show("Hours Worked must be between 0 and 80.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _employee.HoursWorked = hoursWorked;


            // validate pto days, must be number and must be between 0 or 365
            if (!Regex.IsMatch(PTODaysTb.Text, @"^\d+$")) // whole numbers only
            {
                MessageBox.Show("PTO Days must be a whole number. Example: 10", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(PTODaysTb.Text, out int PTODays);
            if (PTODays < 0 || PTODays > 365)
            {
                MessageBox.Show("PTO Days must be between 0 and 365.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _employee.PTODays = PTODays;


            // finds the employee chosen 
            int index = employees.FindIndex(emp => emp.EmployeeId == _employee.EmployeeId);

            if (index >= 0)
            {
                // once found, we replace it and save
                // For the CSV file
                employees[index] = _employee;
                csv.SaveEmployees(path, employees);

                // For the database


                try
                {
                    DatabaseManager db = new DatabaseManager();
                    db.UpdateEmployee(_employee);
                }
                catch
                {
                    Console.WriteLine("There was a problem with the database connection, using CSV file");
                }

                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else 
            {
                MessageBox.Show("Employee not found. Please try again.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
