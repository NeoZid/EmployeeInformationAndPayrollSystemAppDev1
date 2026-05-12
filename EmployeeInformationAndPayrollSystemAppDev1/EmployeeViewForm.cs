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

            if (_employee.HoursWorked > 0)
            {
                hoursWorkedTb.Text = _employee.HoursWorked.ToString();
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

            PTOdaysLabel.Text = _employee.PTODays.ToString();
            hourlyRateLabel.Text = _employee.HourlyRate.ToString();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hoursWorkedTb.Text))
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalGross = pc.CalculateGross(double.Parse(hourlyRateLabel.Text), double.Parse(hoursWorkedTb.Text));
            grossPayLabel.Text = totalGross.ToString();

            double totalNet = pc.CalculateNet(totalGross);
            netPayLabel.Text = totalNet.ToString();

            _employee.HoursWorked = double.Parse(hoursWorkedTb.Text);
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
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Close();
        }
    }
}
