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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Diagnostics;

namespace UI
{
    public partial class KeukenBarOverzicht : Form
    {
        private Order _currentOrder;
        private OrderLineService _orderRegelService;
        private OrderService _orderService;
        private bool isForKitchen;


        private State state1DisplayedOrders;
        private State state2DisplayedOrders;

        public KeukenBarOverzicht(Employee emp)
        {
            InitializeComponent();
            _orderRegelService = new OrderLineService();
            _orderService = new OrderService();
            switch (emp.Role)
            {
                case Role.Chef:
                    isForKitchen = true;
                    this.Text = "Keuken overzicht";
                    break;
                case Role.Bartender:
                    isForKitchen = false;
                    this.Text = "Bar overzicht";
                    break;
                default:
                    LogOut();
                    break;
            }
            HideAllThings();
            ShowRunningOrders();
        }

        private void LogOut()
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void btnLopendeBestellingen_Click(object sender, EventArgs e)
        {
            ShowRunningOrders();
        }

        private void btnAfgerondeBestellingen_Click(object sender, EventArgs e)
        {
            ShowFinishedOrders();
        }

        private void ShowFinishedOrders()
        {
            UpdateState(State.Served, State.Finished, "afgeronde orders");
        }

        private void ShowRunningOrders()
        {
            UpdateState(State.BeingPrepared, State.NotStarted, "lopende orders");
        }


        private void UpdateState(State state1, State state2, string title)
        {
            state1DisplayedOrders = state1;
            state2DisplayedOrders = state2;
            lblTypeOfOrders.Text = title;
            ShowOrders();
        }

        private void ShowOrders()
        {
            ShowComponentsOrders();
            List<Order> displayedOrders = new List<Order>();
            try
            {
                displayedOrders = _orderService.GetOrders(isForKitchen, state1DisplayedOrders, state2DisplayedOrders);
                FillListViewAllOrders(displayedOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er ging iets mis bij het ophalen van de bestellingen: " + ex.Message);
            }


        }

        private void FillListViewAllOrders(List<Order> orders)
        {
            listViewOrders.Clear();
            listViewOrders.Columns.Add("Besteltijd", 120);
            if (state1DisplayedOrders == State.BeingPrepared || state2DisplayedOrders == State.NotStarted)
            {
                listViewOrders.Columns.Add("Wachttijd", 160);
            }
            listViewOrders.Columns.Add("Tafelnummer", 120);
            listViewOrders.View = View.Details;
            FillListviewDataOrders(orders);

        }

        private void FillListviewDataOrders(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                ListViewItem item = new ListViewItem(order.OrderTime.ToString($"{order.OrderTime.Hour:00}:{order.OrderTime.Minute:00}"));
                item.Tag = order;
                if (state1DisplayedOrders == State.BeingPrepared || state2DisplayedOrders == State.NotStarted)
                {
                    item.SubItems.Add($"{(int)order.WaitTime.TotalHours} uur en {order.WaitTime.Minutes} minuten");
                }
                item.SubItems.Add(order.Table.TableNumber.ToString());
                listViewOrders.Items.Add(item);
            }
        }
        /// 

        private void FillListviewsSelectedOrder()
        {
            try
            {
                lblStateOrder.Show();
                if (isForKitchen)
                {
                    FillKitchenOrders();
                }
                else
                {
                    FillBarOrders();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Er ging iets mis bij het ophalen van de bestellingen: " + ex.Message);
            }

        }


        private void FillKitchenOrders()
        {
            StateString stateStringConverter = new StateString();
            lblStateOrder.Text = "Status bestelling: " + stateStringConverter.ToStateString(_currentOrder.StateFood);
            ShowComponentsKitchenOrders();
            List<OrderLine> starters = _orderRegelService.GetKitchenItemsForOrder(isForKitchen, state1DisplayedOrders, state2DisplayedOrders, ItemType.Starter, _currentOrder);
            FillListView(listViewVoorgerechten, starters);
            List<OrderLine> intermediate = _orderRegelService.GetKitchenItemsForOrder(isForKitchen, state1DisplayedOrders, state2DisplayedOrders, ItemType.Intermediate, _currentOrder);
            FillListView(listViewTussengerechten, intermediate);
            List<OrderLine> Main = _orderRegelService.GetKitchenItemsForOrder(isForKitchen, state1DisplayedOrders, state2DisplayedOrders, ItemType.Main, _currentOrder);
            FillListView(listViewHoofdgerecht, Main);
            List<OrderLine> dessert = _orderRegelService.GetKitchenItemsForOrder(isForKitchen, state1DisplayedOrders, state2DisplayedOrders, ItemType.Dessert, _currentOrder);
            FillListView(listViewOrders, dessert);

        }

        private void FillBarOrders()
        {
            StateString stateStringConverter = new StateString();
            lblStateOrder.Text = "Status bestelling: " + stateStringConverter.ToStateString(_currentOrder.StateDrinks);
            List<OrderLine> items = new List<OrderLine>();
            items = _orderRegelService.GetBarItemsForOrder(isForKitchen, state1DisplayedOrders, state2DisplayedOrders, _currentOrder);
            FillListView(listViewOrders, items);
        }


        private void FillListView(System.Windows.Forms.ListView listView, List<OrderLine> orderLines)
        {
            if (state1DisplayedOrders == State.BeingPrepared || state2DisplayedOrders == State.NotStarted)
            {
                btnGereeed.Show();
                btnVoorbereiden.Show();
            }
            else
            {
                btnVoorbereiden.Hide();
                btnGereeed.Hide();
            }

            listView.Columns.Clear();
            listView.Columns.Add("item", 275);
            listView.Columns.Add("comment", 80);
            listView.Columns.Add("aantal", 80);

            listView.View = View.Details;
            listView.Items.Clear();

            foreach (OrderLine orderLine in orderLines)
            {
                ListViewItem item = new ListViewItem(orderLine.Item.Name.ToString());
                item.Tag = orderLine;

                if (orderLine.Comment == string.Empty)
                {
                    orderLine.Comment = "geen";
                }
                item.SubItems.Add(orderLine.Comment);
                item.SubItems.Add(orderLine.Count.ToString());
                listView.Items.Add(item);
            }
        }

        private void btnGereeed_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Weet je zeker dat je de bestelling gereed wilt melden?", "Bevestiging", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CompleteOrder();
                }
                else
                {
                    MessageBox.Show("De bestelling is niet gereed gemeld.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bestelling kon niet gereed gemeld worden " + ex.Message);
            }
        }

        private void btnVoorbereiden_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareOrder();
                FillListviewsSelectedOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bestelling kon niet voorbereid gemeld worden " + ex.Message);
            }
        }

        private void PrepareOrder()
        {
            _currentOrder = _orderService.ChangeOrderState(_currentOrder, State.BeingPrepared, isForKitchen);
        }

        private void CompleteOrder()
        {
            MessageBox.Show($"Bestelling voor tafel {_currentOrder.Table.TableNumber} is gereed gemeld.");
            _currentOrder = _orderService.ChangeOrderState(_currentOrder, State.Finished, isForKitchen);
            ShowOrders();
            _orderService.InsertEndTime(_currentOrder);
        }

        private void listViewOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                try
                {
                    Order order = (Order)listViewOrders.SelectedItems[0].Tag;
                    _currentOrder = order;
                    FillListviewsSelectedOrder();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Er ging iets mis bij het ophalen van de bestellingen: " + ex.Message);
                }

            }

        }


        ///
        private void ShowComponentsKitchenOrders()
        {
            HideAllThings();
            listViewVoorgerechten.Show();
            listViewTussengerechten.Show();
            listViewNagerecht.Show();
            listViewHoofdgerecht.Show();

            lblVoorgerechten.Show();
            lblTussengerechten.Show();
            lblNagerecht.Show();
            lblHoofdgerecht.Show();
            lblStateOrder.Show();
        }

        private void HideAllThings()
        {
            listViewOrders.Hide();
            listViewVoorgerechten.Hide();
            listViewTussengerechten.Hide();
            listViewNagerecht.Hide();
            listViewHoofdgerecht.Hide();

            lblVoorgerechten.Hide();
            lblTussengerechten.Hide();
            lblNagerecht.Hide();
            lblHoofdgerecht.Hide();

            btnGereeed.Hide();
            btnVoorbereiden.Hide();
            lblStateOrder.Hide();
        }

        private void ShowComponentsOrders()
        {
            HideAllThings();
            lblTypeOfOrders.Show();
            listViewOrders.Show();
            lblTypeOfOrders.Show();

        }


    }
}
