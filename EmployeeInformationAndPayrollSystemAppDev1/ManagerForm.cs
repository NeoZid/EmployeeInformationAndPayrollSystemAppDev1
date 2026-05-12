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

            DatabaseManager db = new DatabaseManager();
            db.SyncFromCsv(employees);

            LoadGrid();
        }

        public void LoadGrid()
        {
            CsvManager csv = new CsvManager();
            string path = Application.StartupPath + "\\employees.csv"; // always points to bin/Debug folder 
            List<Employee> employees = csv.LoadEmployees(path);
            employeeDataView.DataSource = employees;
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
                DatabaseManager db = new DatabaseManager();
                db.DeleteEmployee(selected);

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
    }
}
