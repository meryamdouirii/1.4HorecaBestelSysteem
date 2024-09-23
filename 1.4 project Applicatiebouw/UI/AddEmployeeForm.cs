using Model;
using Model.Password;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace UI
{
    public partial class AddEmployeeForm : Form
    {
        Employee employee;
        public AddEmployeeForm(Employee employee)
        {
            InitializeComponent();
            ShowForm();
            this.employee = employee;
        }
        private void ShowForm()
        {
            TextBoxFirstname.Clear();
            TextBoxLastname.Clear();
            DateTimePickerBirthDate.Value = DateTime.Now.AddYears(-19);
            DateTimePickerBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            ComboBoxRole.Items.Clear();
            ComboBoxRole.SelectedIndex = -1;
            ComboBoxRole.Text = "";
            TextBoxPassword.Clear();
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.MaxLength = 4;

            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                ComboBoxRole.Items.Add(role);
            }
        }
        private void AddEmployee()
        {
            if (CheckNull() == true)
            {
                Role role = (Role)ComboBoxRole.SelectedItem;

                PasswordService passwordService = new PasswordService();
                HashWithSaltResult password = passwordService.MakeHashandSalt(TextBoxPassword.Text);

                Employee employee = new Employee()
                {
                    Firstname = TextBoxFirstname.Text,
                    Lastname = TextBoxLastname.Text,
                    BirthDate = DateTimePickerBirthDate.Value.Date,
                    Salt = password.Salt,
                    Hash = password.Hash,
                    Role = role
                };

                EmployeeService employeeService = new EmployeeService();
                employeeService.AddEmployee(employee);

                ShowForm();
                MessageBox.Show("You have added a employee");
            }
            else
            {
                MessageBox.Show("You didn't complete all the required fields");
            }
        }
        private bool CheckNull()
        {
            if (ComboBoxRole.SelectedItem != null
                && !String.IsNullOrEmpty(TextBoxFirstname.Text)
                && !String.IsNullOrEmpty(TextBoxLastname.Text)
                && !String.IsNullOrEmpty(DateTimePickerBirthDate.Text)
                && !String.IsNullOrEmpty(TextBoxPassword.Text))
            {
                return true;
            }
            else { return false; }
        }
        private void Logout()
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
            this.Close();
        }
        private void Back()
        {
            this.Hide();
            ManagerForm ManagerForm = new ManagerForm(employee);
            ManagerForm.ShowDialog();
            this.Close();
        }
        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
