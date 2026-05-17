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
    public partial class ManagerForm : Form
    {
        private Employee _loggedInManager;
        public ManagerForm(Employee manager)
        {
            InitializeComponent();
            _loggedInManager = manager;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // need to sync database and CSV employees 
            string path = Application.StartupPath + "\\employees.csv";
            CsvManager csv = new CsvManager();
            List<Employee> employees = csv.LoadEmployees(path);

            try
            {
                DatabaseManager db = new DatabaseManager();
                db.SyncFromCsv(employees);
            }
            catch
            {
                Console.WriteLine("There was a problem with the database connection, saving to CSV file");
            }

            LoadGrid();
        }

        public void LoadGrid()
        {
            CsvManager csv = new CsvManager();
            string path = Application.StartupPath + "\\employees.csv"; // always points to bin/Debug folder 
            List<Employee> employees = csv.LoadEmployees(path);
            employeeDataView.DataSource = employees;

            // hide sensitive data
            employeeDataView.Columns["Password"].Visible = false;

            // rename columns based on current language
            string culture = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;

            // translate info from the datagrid view
            if (culture == "fr-CA")
            {
                employeeDataView.Columns["FirstName"].HeaderText = "Prénom";
                employeeDataView.Columns["LastName"].HeaderText = "Nom de famille";
                employeeDataView.Columns["EmployeeId"].HeaderText = "Identifiant";
                employeeDataView.Columns["DateOfBirth"].HeaderText = "Date de naissance";
                employeeDataView.Columns["Email"].HeaderText = "Courriel";
                employeeDataView.Columns["Role"].HeaderText = "Rôle";
                employeeDataView.Columns["Department"].HeaderText = "Département";
                employeeDataView.Columns["HourlyRate"].HeaderText = "Taux horaire";
                employeeDataView.Columns["HoursWorked"].HeaderText = "Heures travaillées";
                employeeDataView.Columns["PTODays"].HeaderText = "Jours de congé";
            }
            else if (culture == "es")
            {
                employeeDataView.Columns["FirstName"].HeaderText = "Nombre";
                employeeDataView.Columns["LastName"].HeaderText = "Apellido";
                employeeDataView.Columns["EmployeeId"].HeaderText = "ID de empleado";
                employeeDataView.Columns["DateOfBirth"].HeaderText = "Fecha de nacimiento";
                employeeDataView.Columns["Email"].HeaderText = "Correo electrónico";
                employeeDataView.Columns["Role"].HeaderText = "Rol";
                employeeDataView.Columns["Department"].HeaderText = "Departamento";
                employeeDataView.Columns["HourlyRate"].HeaderText = "Tarifa por hora";
                employeeDataView.Columns["HoursWorked"].HeaderText = "Horas trabajadas";
                employeeDataView.Columns["PTODays"].HeaderText = "Días de vacaciones";
            }
            else // English default
            {
                employeeDataView.Columns["FirstName"].HeaderText = "First Name";
                employeeDataView.Columns["LastName"].HeaderText = "Last Name";
                employeeDataView.Columns["EmployeeId"].HeaderText = "Employee ID";
                employeeDataView.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                employeeDataView.Columns["Email"].HeaderText = "Email";
                employeeDataView.Columns["Role"].HeaderText = "Role";
                employeeDataView.Columns["Department"].HeaderText = "Department";
                employeeDataView.Columns["HourlyRate"].HeaderText = "Hourly Rate";
                employeeDataView.Columns["HoursWorked"].HeaderText = "Hours Worked";
                employeeDataView.Columns["PTODays"].HeaderText = "PTO Days";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm rs = new RegisterForm(this);
            rs.ShowDialog();
            LoadGrid();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (employeeDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee selected = (Employee)employeeDataView.SelectedRows[0].DataBoundItem;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to remove " + selected.GetFullName() + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string path = Application.StartupPath + "\\employees.csv";
                CsvManager csv = new CsvManager();
                List<Employee> employees = csv.LoadEmployees(path);
                employees.RemoveAll(emp => emp.EmployeeId == selected.EmployeeId);
                csv.SaveEmployees(path, employees);

                // Database
                
                try
                {
                    DatabaseManager db = new DatabaseManager();
                    db.DeleteEmployee(selected);
                }
                catch
                {
                    Console.WriteLine("There was a problem with the database connection, using CSV file now");
                }

                LoadGrid();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (employeeDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee selected = (Employee)employeeDataView.SelectedRows[0].DataBoundItem;
            EditEmployeeForm editForm = new EditEmployeeForm(selected);
            editForm.ShowDialog();
            LoadGrid();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Close();
        }
    }
}
