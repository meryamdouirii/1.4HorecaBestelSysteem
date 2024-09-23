using Model;
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

namespace UI
{
    public partial class TablesForm : Form
    {
        Employee employee;
        public TablesForm(Employee employee)
        {
            InitializeComponent();
            ShowTables();
            this.employee = employee;
        }

        private void ShowTables()
        {
            try
            {
                List<Table> Tables = GetTables();
                DisplayTables(Tables);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Table> GetTables()
        {
            TableService TableService = new TableService();
            List<Table> Tables = TableService.GetTables();
            return Tables;
        }

        private void DisplayTables(List<Table> Tables)
        {
            int buttonWidth = 100;
            int buttonHeight = 100;
            int columns = 5;
            int spacing = 10;

            int startY = this.ClientSize.Height / 2 - 100; // Adjust as needed
            int startX = ((this.ClientSize.Width / 2) - ((buttonWidth + spacing) * 2) - (buttonWidth / 2));


            for (int i = 0; i < Tables.Count; i++)
            {
                Button button = new Button();
                button.Text = Tables[i].TableNumber.ToString();
                button.ForeColor = Color.White;
                button.Font = new Font(button.Font.FontFamily, 15, FontStyle.Bold);
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.BackColor = GetColor(Tables[i]);

                int row = i / columns;
                int col = i % columns;
                int x = startX + col * (buttonWidth + spacing);
                int y = startY + row * (buttonHeight + spacing);

                button.Location = new System.Drawing.Point(x, y);

                int index = i;
                button.Click += (sender, e) =>
                {
                    this.Hide();
                    SingleTableForm SingleTableForm = new SingleTableForm(Tables[index], employee);
                    SingleTableForm.ShowDialog();
                    this.Close();
                };

                // Add the button to the form
                this.Controls.Add(button);
            }
        }

        private Color GetColor(Table table)
        {
            if (table.IsReserved == true)
            {
                return Color.OrangeRed;
            }
            else
            {
                return Color.LimeGreen;
            }
        }

        private void Logout()
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
            this.Close();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
