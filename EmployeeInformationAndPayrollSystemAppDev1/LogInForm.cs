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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        

        private void signInButton_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(userIdTb.Text) || (string.IsNullOrEmpty(passwordTb.Text)))
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (userIdTb.Text == "ADMIN" && passwordTb.Text == "ADMIN123")
            {
                // RegisterForm rf = new RegisterForm();

                //rf.Show();

                Employee adminEmployee = new Employee("Admin", "User", "ADMIN",
                DateTime.Now, "admin@company.com", "ADMIN123", "Manager", "Management", 0);

                ManagerForm mf = new ManagerForm(adminEmployee);
                mf.Show();
                this.Hide();
                return;

                
            }
            // <-- used when data isnt loaded properly

            CsvManager csv = new CsvManager();

            List<Employee> employees = csv.LoadEmployees("employees.csv");

            Employee found = employees.Find(emp => emp.EmployeeId  == userIdTb.Text);

            if (found == null)
            {
                MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (found.Password != passwordTb.Text)
            {
                MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (found.Department == "Management")
            {
                // manager dashboard
            } else
            {
                // employee view
            }
        }

        
    }
}
