using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;

namespace UI
{
    public partial class SingleTableForm : Form
    {
        private Table table;
        private Employee employee;
        public SingleTableForm(Table input, Employee employee)
        {
            InitializeComponent();
            this.table = input;
            ShowTable(table);
            ShowWaitingTime();
            this.employee = employee;
        }

        private void ShowWaitingTime()
        {
            List<WaitingTime> waitingTimes = GetWaitingTime();
            DisplayWaitingTime(waitingTimes);

        }

        private List<WaitingTime> GetWaitingTime()
        {
            TableService tableService = new TableService();
            List<WaitingTime> waitingTimes = tableService.GetWaitingTime(table);
            return waitingTimes;
        }

        private void DisplayWaitingTime(List<WaitingTime> waitingTimes)
        {
            if (waitingTimes.Count > 0)
            {
                string timewaiting = waitingTimes[0].timewaiting.ToString();
                LabelWaitingTime.Text = $"Deze tafel is al {timewaiting} minuten aan het wachten!!";
            }
        }

        private void ShowTable(Table table)
        {
            Label label = new Label();
            label.Text = "Table " + table.TableNumber.ToString();
            label.Font = new Font(label.Font.FontFamily, 25, FontStyle.Bold);
            label.AutoSize = true;

            label.Location = new Point((this.ClientSize.Width / 2) - label.Width, 25);

            this.Controls.Add(label);
            Herlaad();
        }

        private void Seat()
        {
            if (this.table.IsReserved == true)
            {
                MessageBox.Show("Tafel is al gereserveerd");
            }
            else
            {
                UpdateReservation(table);
                table.IsReserved = true;
            }
            Herlaad();
        }
        private void Unseat()
        {
            if (this.table.IsReserved == false)
            {
                MessageBox.Show("Tafel is al leeg");
            }
            else
            {
                UpdateReservation(table);
                table.IsReserved = false;
            }
            Herlaad();
        }

        private void UpdateReservation(Table table)
        {
            TableService tableService = new TableService();
            tableService.UpdateTableReservation(table);
        }
        private void Herlaad()
        {
            if (table.IsReserved == true)
            {
                ButtonSeat.Hide();
                ButtonUnseat.Show();
                ButtonBestelling.Enabled = true;
            }
            else
            {
                ButtonUnseat.Hide();
                ButtonSeat.Show();
                ButtonBestelling.Enabled = false;
            }

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
            TablesForm TablesForm = new TablesForm(employee);
            TablesForm.ShowDialog();
            this.Close();
        }
        void OpenOrderDetailsForm(Table table)
        {
            this.Hide();
            OrderDetailsForm orderDetailsForm = new OrderDetailsForm(table, employee);
            orderDetailsForm.ShowDialog();
            this.Close();
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void ButtonSeat_Click(object sender, EventArgs e)
        {
            Seat();
        }

        private void ButtonUnseat_Click(object sender, EventArgs e)
        {
            Unseat();
        }

        private void ButtonBestelling_Click(object sender, EventArgs e)
        {
            OpenOrderDetailsForm(this.table);
        }
    }
}
