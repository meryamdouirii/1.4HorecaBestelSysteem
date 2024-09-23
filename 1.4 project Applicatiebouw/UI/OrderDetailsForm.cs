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
    public partial class OrderDetailsForm : Form
    {
        private Table table;
        private Employee employee;
        public OrderDetailsForm(Table table, Employee employee)
        {
            InitEmployee(employee);
            InitTable(table);
            InitializeComponent();
            InitializeListView();
            tableNrLbl.Text = $"Tafel {table.TableNumber}";
            PopulateTabMenus();

        }

        private void InitTable(Table table)
        {
            if (table == null)
            {
                MessageBox.Show("Something went wrong initializing the table! Going back to Table Overview");
                OpenOverview();
            }
            else
            {
                this.table = table;
            }
        }
        private void InitEmployee(Employee emp)
        {
            if (emp == null)
            {
                MessageBox.Show("Something went wrong initializing employee! Logging out.");
                LogOut();
            }
            else
            {
                employee = emp;
            }
        }
        private void PopulateTabMenus()
        {
            PopulateTabPage(Menu.Lunch, tabControlCategoryLunch);
            PopulateTabPage(Menu.Dinner, tabControlCategoryDiner);
            PopulateTabPage(Menu.Drink, tabControlCategoryDrinks);
        }

        private void PopulateTabPage(Menu menu, TabControl tabcontrol)
        {
            List<Item> allMenuItems = GetItemsByMenu(menu);

            foreach (TabPage tabPage in tabcontrol.TabPages)
            {
                ItemType itemType = (ItemType)tabPage.Tag; // elke tabpage heeft een .Tag met de bijbehorende type. 
                List<Item> filteredItems = allMenuItems.Where(item => item.Type == itemType).ToList(); // Zet alle items met het type van de .Tag in één list.
                AddButtonsToTab(filteredItems, tabPage); // Voegt de filtereditems to aan de bijbehorende tabpage.
            }
        }

        private List<Item> GetItemsByMenu(Menu menu)
        {
            ItemService itemService = new ItemService();
            return itemService.GetItemsByMenu(menu);
        }
        private void AddButtonsToTab(List<Item> items, TabPage tabPage)
        {
            int buttonWidth = 470;
            int buttonHeight = 60;
            int padding = 10;
            int currentY = padding;

            foreach (Item item in items)
            {
                Button button = new Button();
                button.Text = item.Name;
                button.Tag = item;
                button.Enabled = item.Stock > 0;
                button.Size = new Size(buttonWidth, buttonHeight);
                button.Location = new Point(padding, currentY);
                button.Click += ItemButton_Click;
                tabPage.Controls.Add(button);
                currentY += buttonHeight + padding;
            }
        }

        private void CreateOrderLine(Item item)
        {
            try
            {
                bool found = false;
                if (itemsLv.Items.Count == 0)
                {
                    AddNewOrderLine(item);
                    return;
                }
                foreach (ListViewItem listViewItem in itemsLv.Items)
                {
                    OrderLine existingOrderLine = (OrderLine)listViewItem.Tag;
                    if (existingOrderLine.Item == item)
                    {
                        UpdateExistingOrderLine(listViewItem, item);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    AddNewOrderLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateExistingOrderLine(ListViewItem listViewItem, Item item)
        {
            OrderLine existingOrderLine = (OrderLine)listViewItem.Tag;
            if (existingOrderLine.Count + 1 > item.Stock)
            {
                throw new Exception($"Ordered amount is bigger than stock! Stock: {item.Stock}");
            }
            existingOrderLine.Count++;
            listViewItem.SubItems[1].Text = existingOrderLine.Count.ToString();
        }
        private void AddNewOrderLine(Item item)
        {
            if (item.Stock <= 0) throw new Exception("Insufficient stock!");
            OrderLine orderLine = new OrderLine(item);
            ListViewItem listViewItem = new ListViewItem(orderLine.Item.Name);
            listViewItem.Tag = orderLine;
            listViewItem.SubItems.Add(orderLine.Count.ToString());
            listViewItem.SubItems.Add(orderLine.Comment);
            itemsLv.Items.Add(listViewItem);
        }

        private void InitializeListView()
        {
            itemsLv.Clear();
            itemsLv.CheckBoxes = true;
            itemsLv.Columns.Add("Naam", 200);
            itemsLv.Columns.Add("Aantal", 55);
            itemsLv.Columns.Add("Comment", 210);
            itemsLv.View = View.Details;
        }

        private ListViewItem GetSelectedListViewItem()
        {
            if (!(itemsLv.CheckedItems.Count == 1))
            {
                throw new Exception("Selecteer één regel om te verwijderen/wijzigen");
            }
            else
            {
                return itemsLv.CheckedItems[0];
            }
        }

        private void GoBack()
        {
            if (itemsLv.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Weet je zeker dat je terug wilt gaan? De huidige order is nog niet verstuurd!", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) OpenOverview();
            }
            else
            {
                OpenOverview();// Als geen items in order, teruggaan zonder bevestiging
            }
        }

        private void SendOrder()
        {
            try
            {
                List<OrderLine> orderLines = GetOrderLines();
                if (orderLines.Count > 0)
                {
                    OrderService orderService = new OrderService();
                    orderService.AddOrder(new Order(table, orderLines));
                    MessageBox.Show("Order sent.");
                    OpenOverview();
                }
                else
                {
                    MessageBox.Show("No items in order to send!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<OrderLine> GetOrderLines()
        {
            List<OrderLine> orderLines = new List<OrderLine>();
            foreach (ListViewItem listViewItem in itemsLv.Items)
            {
                OrderLine orderLine = (OrderLine)listViewItem.Tag;
                if (orderLine != null)
                {
                    orderLines.Add(orderLine);
                }
            }
            return orderLines;
        }

        private void DeleteOrderLine()
        {
            try
            {
                ListViewItem itemToDelete = GetSelectedListViewItem();
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected order line?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        itemsLv.Items.Remove(itemToDelete);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void EditOrderLine()
        {
            try
            {
                ListViewItem selectedItem = GetSelectedListViewItem();
                OrderLine orderLineToEdit = (OrderLine)selectedItem.Tag;
                if (orderLineToEdit != null)
                {
                    EditOrderRegelForm editForm = new EditOrderRegelForm(orderLineToEdit);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedItem.SubItems[1].Text = orderLineToEdit.Count.ToString();
                        selectedItem.SubItems[2].Text = orderLineToEdit.Comment;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void OpenOverview()
        {
            this.Hide();
            TablesForm TablesForm = new TablesForm(employee);
            TablesForm.ShowDialog();
            this.Close();
        }

        private void LogOut()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
        private void ItemButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)button.Tag;
            CreateOrderLine(item);
        }
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendOrder();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteOrderLine();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            EditOrderLine();
        }
    }
}




