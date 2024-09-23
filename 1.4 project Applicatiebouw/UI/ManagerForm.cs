using Service;
using Model;

namespace UI
{
    public partial class ManagerForm : Form
    {
        Employee employee;
        public ManagerForm(Employee employee)
        {
            InitializeComponent();
            ShowEmployees();
            this.employee = employee;
        }

        private void ShowEmployees()
        {
            try
            {
                List<Employee> Employees = GetEmployees();
                DisplayEmployees(Employees);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private List<Employee> GetEmployees()
        {
            EmployeeService EmployeeService = new EmployeeService();
            List<Employee> Employees = EmployeeService.GetEmployees();
            return Employees;
        }
        private void DisplayEmployees(List<Employee> Employees)
        {
            ListViewEmployee.Clear();

            ListViewEmployee.View = View.Details;

            ListViewEmployee.Columns.Add("Naam", 200, HorizontalAlignment.Left);
            ListViewEmployee.Columns.Add("Leeftijd", 100, HorizontalAlignment.Left);
            ListViewEmployee.Columns.Add("Rol", 100, HorizontalAlignment.Left);

            foreach (Employee Employee in Employees)
            {
                ListViewItem li = new ListViewItem(Employee.Fullname);

                li.Tag = Employee;

                li.SubItems.Add(Employee.Age.ToString());
                li.SubItems.Add(Employee.Role.ToString());

                ListViewEmployee.Items.Add(li);
            }
        }

        private void RemoveEmployee()
        {
            EmployeeService employeeService = new EmployeeService();

            ListViewItem selecteditem = ListViewEmployee.SelectedItems[0];
            Employee employee = selecteditem.Tag as Employee;

            employeeService.RemoveEmployee(employee);

            ShowEmployees();
        }
        private void AddEmployee()
        {
            this.Hide();
            AddEmployeeForm AddEmployeeForm = new AddEmployeeForm(employee);
            AddEmployeeForm.ShowDialog();
            this.Close();
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
            ManagerMenuForm ManagerMenuForm = new ManagerMenuForm(employee);
            ManagerMenuForm.ShowDialog();
            this.Close();
        }

        private void ButtonRemoveEmployee_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
        }

        private void ButtonGoToAddEmployee_Click(object sender, EventArgs e)
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
