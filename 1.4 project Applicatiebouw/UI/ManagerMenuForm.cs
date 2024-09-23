using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerMenuForm : Form
    {
        Employee employee;
        public ManagerMenuForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void GotoManager()
        {
            this.Hide();
            ManagerForm ManagerForm = new ManagerForm(employee);
            ManagerForm.ShowDialog();
            this.Close();
        }

        private void GotoPayment()
        {
            this.Hide();
            Payment form = new Payment(employee);
            form.ShowDialog();
            this.Close();
        }

        private void GotoMenus()
        {
            this.Hide();
            Menus form = new Menus(employee);
            form.ShowDialog();
            this.Close();
        }
        private void Logout()
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
            this.Close();
        }

        private void GotoTables()
        {
            this.Hide();
            TablesForm tablesForm = new TablesForm(employee);
            tablesForm.ShowDialog();
            this.Close();
        }
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void ButtonMainManager_Click_1(object sender, EventArgs e)
        {
            GotoManager();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            GotoPayment();
        }

        //private void btnFoodMenu_Click(object sender, EventArgs e)
        //{
        //    GotoFood();
        //}

        private void btnDrinkMenu_Click(object sender, EventArgs e)
        {
            GotoMenus();
        }

        private void tableOverviewBtn_Click(object sender, EventArgs e)
        {
            GotoTables();
        }
    }
}
