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

            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; // allowed characters before @, valid domain format and atleast 2 letter domain extension ex: .com/.ca/.org

            if (string.IsNullOrWhiteSpace(fNameTb.Text) || string.IsNullOrWhiteSpace(lNameTb.Text) || string.IsNullOrWhiteSpace(emailTb.Text)  
                || string.IsNullOrWhiteSpace(PTODaysTb.Text) || string.IsNullOrWhiteSpace(hoursWorkedTb.Text) ||
                string.IsNullOrWhiteSpace(hourlyRateTb.Text) || departmentCb.SelectedIndex == -1 || roleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fNameTb.Text.Length < 2 || lNameTb.Text.Length < 2)
            {
                MessageBox.Show("First and Last name must be at least 2 characters.");
                return;
            }

            _employee.FirstName = fNameTb.Text;
            _employee.LastName = lNameTb.Text;

            if (!Regex.IsMatch(emailTb.Text, emailRegex))
            {
                MessageBox.Show("Email must have @, valid domain format and atleast 2 letter domain extension", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _employee.Email = emailTb.Text;
            _employee.DateOfBirth = bdayTimePicker.Value;
            _employee.Department = departmentCb.Text;
            _employee.Role = roleCb.Text;
            

            if (!double.TryParse(hourlyRateTb.Text, out double hourlyRate) )
            {
                MessageBox.Show("Hourly Rate must be a number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _employee.HourlyRate = hourlyRate;
            if (!double.TryParse(hoursWorkedTb.Text, out double hoursWorked))
            {
                MessageBox.Show("Hours Worked must be a number!", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hoursWorked < 0 || hoursWorked > 80)
            {
                MessageBox.Show("Hours Worked must be between 0 and 80.");
                return;
            }
            _employee.HoursWorked = hoursWorked;

            if (!int.TryParse(PTODaysTb.Text, out int PTODays))
            {
                MessageBox.Show("PTO Days must be a number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PTODays < 0 || PTODays > 365)
            {
                MessageBox.Show("PTO Days must be between 0 and 365.");
                return;
            }
            _employee.PTODays = PTODays;




            string path = Application.StartupPath + "\\employees.csv";
            CsvManager csv = new CsvManager();
            List<Employee> employeees = csv.LoadEmployees(path);
            // finds the employee chosen 
            int index = employeees.FindIndex(emp => emp.EmployeeId == _employee.EmployeeId);

            if (index >= 0)
            {
                // once found, we replace it and save
                // For the CSV file
                employeees[index] = _employee;
                csv.SaveEmployees(path, employeees);

                // For the database
                

                try
                {
                    DatabaseManager db = new DatabaseManager();
                    db.InsertEmployee(_employee);
                }
                catch
                {
                    Console.WriteLine("There was a problem with the database connection, using CSV file");
                }

                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
        }
    }
}
