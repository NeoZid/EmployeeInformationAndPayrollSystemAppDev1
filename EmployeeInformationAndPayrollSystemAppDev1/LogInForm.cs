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
        private bool _isLoading = true;
        public LogInForm()
        {
            InitializeComponent();
            
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            languageCb.SelectedIndex = 0;
            _isLoading = false;
        }

        private void signInButton_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(userIdTb.Text) || (string.IsNullOrEmpty(passwordTb.Text)))
            {
                MessageBox.Show("Please fill out all of the fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // <-- used when data isnt loaded properly
            
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
            string path = Application.StartupPath + "\\employees.csv";
            List<Employee> employees = csv.LoadEmployees(path);

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
                ManagerForm mf = new ManagerForm(found);
                mf.Show();
                this.Hide();
            } else
            {
                EmployeeViewForm ef = new EmployeeViewForm(found);
                ef.Show();
                this.Hide();
            }
        }

        private void languageCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            int selectedIndex = languageCb.SelectedIndex;
            string culture = "en";

            if (languageCb.SelectedItem.ToString() == "Français")
            {
                culture = "fr-CA";
            } else if (languageCb.SelectedItem.ToString() == "Español") {
                culture = "es";
            }
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);

            LogInForm newForm = new LogInForm();
            newForm.Show();
            newForm.SetLanguageIndex(selectedIndex);
            this.Hide();
        }

        public void SetLanguageIndex(int index)
        {
            _isLoading = true;
            languageCb.SelectedIndex = index;
            _isLoading = false;
        }
    }
}
