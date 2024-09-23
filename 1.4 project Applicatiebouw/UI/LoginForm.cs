using Model;
using Model.Password;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            try
            {
                TextBoxPassword.PasswordChar = '*';
                TextBoxPassword.MaxLength = 4;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Employees: " + e.Message);
            }
        }
        /*private List<Employee> GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employees = employeeService.GetEmployees();
            return employees;
        }
        private void DisplayEmployees(List<Employee> employees)
        {
            ComboBoxLogin.Items.Clear();

            foreach (Employee Employee in employees)
            {
                ComboBoxLogin.Items.Add(Employee);
            }
            ComboBoxLogin.DisplayMember = "Fullname";
        }*/
        private Employee GetEmployee()
        {
            EmployeeService employeeService = new EmployeeService();
            return employeeService.GetEmployeeByName(TextBoxFirstname.Text);
        }
        private void Login()
        {
            Employee selectedEmployee = GetEmployee();
            PasswordService passwordService = new PasswordService();
            bool passwordCorrect = false;
            if (selectedEmployee != null && selectedEmployee.Salt != null && selectedEmployee.Hash != null)
            {
                passwordCorrect = passwordService.VerifyPassword(TextBoxPassword.Text, selectedEmployee.Salt, selectedEmployee.Hash);
            }
            if (selectedEmployee != null && passwordCorrect == true)
            {
                this.Hide();
                SwitchForm(selectedEmployee);
                this.Close();
            }
            else
            {
                MessageBox.Show("Verkeerde Wachtwoord of gebruikersnaam!");
            }
        }

        private void SwitchForm(Employee emp)
        {
            switch (emp.Role)
            {
                case Role.Waitress:
                    TablesForm TablesForm = new TablesForm(emp);
                    TablesForm.ShowDialog();
                    break;
                case Role.Manager:
                    ManagerMenuForm ManagerMenuForm = new ManagerMenuForm(emp);
                    ManagerMenuForm.ShowDialog();
                    break;
                case Role.Bartender:
                    KeukenBarOverzicht BarOverzicht = new KeukenBarOverzicht(emp);
                    BarOverzicht.ShowDialog();
                    break;
                case Role.Chef:
                    KeukenBarOverzicht KeukenOverzicht = new KeukenBarOverzicht(emp);
                    KeukenOverzicht.ShowDialog();
                    break;
                default: break;
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
