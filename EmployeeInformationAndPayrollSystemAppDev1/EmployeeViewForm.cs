using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    public partial class EmployeeViewForm : Form
    {
        private Employee _employee;
        private PayrollCalculator pc = new PayrollCalculator();
        public EmployeeViewForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = _employee.GetFullName();
            idLabel.Text = _employee.EmployeeId;
            departmentLabel.Text = _employee.Department;
            roleLabel.Text = _employee.Role;
            hourlyRateLabel.Text = "$" + _employee.HourlyRate.ToString("F2");
            PTOdaysLabel.Text = _employee.PTODays.ToString();

            if (_employee.HoursWorked > 0)
            {
                hoursWorkedTb.Text = _employee.HoursWorked.ToString(CultureInfo.InvariantCulture);
                double gross = pc.CalculateGross(_employee.HourlyRate, _employee.HoursWorked);
                double net = pc.CalculateNet(gross);
                grossPayLabel.Text = "$" + gross.ToString("F2");
                netPayLabel.Text = "$" + net.ToString("F2");
            }
            else
            {
                grossPayLabel.Text = "Enter hours to calculate";
                netPayLabel.Text = "Enter hours to calculate";
            }

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hoursWorkedTb.Text))
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validation for hours worked
            if (!Regex.IsMatch(hoursWorkedTb.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("Hours Worked must be a valid number. Example: 40 or 37.5", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double.TryParse(hoursWorkedTb.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double hours);
            // check hours 
            if (hours < 0 || hours > 80)
            {
                MessageBox.Show("Hours Worked must be between 0 and 80.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _employee.HoursWorked = hours;

            // calculate
            double totalGross = pc.CalculateGross(_employee.HourlyRate, hours);
            double totalNet = pc.CalculateNet(totalGross);

            // update the labels
            netPayLabel.Text = "$" + totalNet.ToString("F2");
            grossPayLabel.Text = "$" + totalGross.ToString("F2");

            // save csv
            string path = Application.StartupPath + "\\employees.csv";
            CsvManager csv = new CsvManager();
            List<Employee> employeees = csv.LoadEmployees(path);
            // finds the employee chosen 
            int index = employeees.FindIndex(emp => emp.EmployeeId == _employee.EmployeeId);

            if (index >= 0)
            {
                // once found, we replace it and save
                employeees[index] = _employee;
                csv.SaveEmployees(path, employeees);
            }

            // save database
            try 
            {
                DatabaseManager db = new DatabaseManager();
                db.UpdateEmployee(_employee);
            } catch
            {

            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Close();
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newPasswordTb.Text) || string.IsNullOrWhiteSpace(confirmPasswordTb.Text))
            {
                MessageBox.Show("Please fill in both password fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPasswordTb.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPasswordTb.Text != confirmPasswordTb.Text)
            {
                MessageBox.Show("Passwords do not match.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _employee.Password = newPasswordTb.Text;

            string path = Application.StartupPath + "\\employees.csv";
            CsvManager csv = new CsvManager();
            List<Employee> employees = csv.LoadEmployees(path);
            int index = employees.FindIndex(emp => emp.EmployeeId == _employee.EmployeeId);
            if (index >= 0)
            {
                employees[index] = _employee;
                csv.SaveEmployees(path, employees);
            }

            try
            {
                DatabaseManager db = new DatabaseManager();
                db.UpdateEmployee(_employee);
            }
            catch { }

            MessageBox.Show("Password changed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            newPasswordTb.Text = string.Empty;
            confirmPasswordTb.Text = string.Empty;
        }
    }
}
