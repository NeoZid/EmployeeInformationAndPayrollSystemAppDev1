using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    public partial class RegisterForm : Form
    {
        private LogInForm _loginForm;
        public RegisterForm()
        {
            InitializeComponent();
            
        }

        public RegisterForm(LogInForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CsvManager csv = new CsvManager();
            List<Employee> employees = csv.LoadEmployees("employees.csv");
            int nextNumber = employees.Count + 1;
            employeeIdTb.Text = "EMP" + nextNumber.ToString("D3");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fNameTb.Text) || string.IsNullOrEmpty(lNameTb.Text) || string.IsNullOrEmpty(emailTb.Text) || 
                string.IsNullOrEmpty(passwordTb.Text) ||
                string.IsNullOrEmpty(hourlyRateTb.Text) || roleCb.SelectedIndex == -1 || departmentCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string firstName = fNameTb.Text;
            string lastName = lNameTb.Text;
            string email = emailTb.Text;
            string password = passwordTb.Text;
            DateTime birthDay = bdayTimePicker.Value;
            string employeeId = employeeIdTb.Text;
            string department = departmentCb.Text;
            string role = roleCb.Text;
            double hourlyRate = double.Parse(hourlyRateTb.Text);
            Employee employee1 = new Employee(firstName, lastName, employeeId, birthDay, email, password,role, department, hourlyRate);

            CsvManager csv = new CsvManager();

            List<Employee> employees = csv.LoadEmployees("employees.csv");
            employees.Add(employee1);
            csv.SaveEmployees("employees.csv", employees);

            MessageBox.Show("Employee Register successfully!" , "Success", MessageBoxButtons.OK , MessageBoxIcon.Information);
            this.Close();
        }
    }
}
