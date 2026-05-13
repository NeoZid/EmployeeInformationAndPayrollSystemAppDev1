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
            if (!double.TryParse(hourlyRateTb.Text, out double hourlyRate))
            {
                MessageBox.Show("Hourly Rate must be a number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            
            Employee employee1 = new Employee(firstName, lastName, employeeId, birthDay, email, password,role, department, hourlyRate);

            // For the csv
            CsvManager csv = new CsvManager();
            string path = Application.StartupPath + "\\employees.csv"; // always points to bin/Debug
            List<Employee> employees = csv.LoadEmployees(path);
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
    }
}
