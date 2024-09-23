using DAL;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace UI
{

    public partial class Payment : Form
    {
        private List<OrderLine> unpaidLines;
        private List<Order> unpaidOrders;
        private List<Item> selectedItems;
        private List<Receipt> receiptList;
        Employee employee;
        public Payment(Employee employee)
        {
            InitializeComponent();
            this.Load += Payment_Load;
            this.employee = employee;
            unpaidLines = new List<OrderLine>();
            unpaidOrders = new List<Order>();
            selectedItems = new List<Item>();
            receiptList = new List<Receipt>();
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            List<Table> tables = RetrieveTableNumbers();
            RetrieveUnpaidOrders();
            RetrieveUnpaidLines(unpaidOrders);
            FillUiElements(tables);
        }
        private void RetrieveUnpaidOrders()
        {
            try
            {
                OrderService orderService = new OrderService();
                unpaidOrders = orderService.RetrieveUnpaidOrders();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving unpaid orders: {ex.Message}");
                unpaidOrders = new List<Order>();
            }
        }
        private void RetrieveUnpaidLines(List<Order> unpaidOrders)
        {
            OrderLineService orderLineService = new OrderLineService();

            try
            {
                foreach (Order order in unpaidOrders)
                {
                    unpaidLines.AddRange(orderLineService.RetrieveOrderLines(order.OrderId));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving unpaid order lines: {ex.Message}");
                unpaidLines = new List<OrderLine>();
            }
        }

        private void FillUiElements(List<Table> tables)
        {
            List<int> tableNumbers = new List<int>();

            foreach (Table table in tables)
            {
                tableNumbers.Add(table.TableNumber);
            }

            combobox_TableNumbers.DataSource = tableNumbers;

            List<PaymentMethod> paymentMethods = Enum.GetValues(typeof(PaymentMethod)).Cast<PaymentMethod>().ToList(); //cast int into list
            combobox_SelectPaymentMethod.DataSource = paymentMethods;
        }

        private List<Table> RetrieveTableNumbers()
        {
            TableService tableService = new TableService();

            try
            {
                return tableService.GetTables();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving tables: {ex.Message}");
                return new List<Table>(); //empty list in case of error
            }
        }
        private void Back()
        {
            this.Hide();
            ManagerMenuForm managerMenuForm = new ManagerMenuForm(employee);
            managerMenuForm.ShowDialog();
            this.Close();
        }


        private void combobox_TableNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTableNumber = (int)combobox_TableNumbers.SelectedItem;
            int orderId = RetrieveOrderId(selectedTableNumber);
            txt_boxOrderId.Text = orderId.ToString();
            List<Item> items = GetCorrespondingOrderItems(orderId);
            List<decimal> pricesWithVatSubtracted = GetPricesWithoutVat(items);
            ShowSelectedOrder(items, pricesWithVatSubtracted);
            PopulateAmountToBePaidTextbox(items);
        }

        private int RetrieveOrderId(int tableNumber)
        {
            foreach (Order order in unpaidOrders)
            {
                if (tableNumber == order.Table.TableNumber)
                {
                    return order.OrderId;
                }
            }

            return 0;
        }
        private void ShowSelectedOrder(List<Item> items, List<decimal> pricesWithoutVat)
        {
            CreateListView();
            int count = 0;
            foreach (Item itemToBeShown in items)
            {
                ListViewItem item = new ListViewItem(itemToBeShown.Name);
                item.SubItems.Add(itemToBeShown.Price.ToString());
                item.SubItems.Add(itemToBeShown.Vat.ToString());
                item.SubItems.Add(pricesWithoutVat[count].ToString("F2"));
                listViewOrdersByTables.Items.Add(item);
                count++;
            }
        }
        private List<Item> GetCorrespondingOrderItems(int orderId)
        {
            List<Item> items = new List<Item>();

            foreach (OrderLine orderLine in unpaidLines)
            {
                if (orderLine.OrderID == orderId)
                {
                    items.Add(orderLine.Item);
                }
            }

            return items;
        }
        List<decimal> GetPricesWithoutVat(List<Item> items)
        {
            List<decimal> pricesWithoutVat = new List<decimal>();

            foreach (Item item in items)
            {
                decimal priceWithoutVat = item.Price / (1 + item.Vat);
                pricesWithoutVat.Add(priceWithoutVat);
            }
            return pricesWithoutVat;
        }
        private void CreateListView()
        {
            listViewOrdersByTables.Clear();
            listViewOrdersByTables.View = View.Details;
            listViewOrdersByTables.Columns.Add("Item name", 90, HorizontalAlignment.Left);
            listViewOrdersByTables.Columns.Add("Price", 90, HorizontalAlignment.Left);
            listViewOrdersByTables.Columns.Add("Vat", 90, HorizontalAlignment.Left);
            listViewOrdersByTables.Columns.Add("Price no VAT", 90, HorizontalAlignment.Left);
        }
        private void PopulateAmountToBePaidTextbox(List<Item> items)
        {
            decimal TotalPrice = 0;

            foreach (Item item in items)
            {
                TotalPrice += item.Price;
            }

            txtbox_AmountToBePaid.Text = TotalPrice.ToString();
        }
        private void listViewOrdersByTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItems.Clear();

            decimal totalSelectedPrice = 0;

            foreach (ListViewItem selectedItem in listViewOrdersByTables.SelectedItems)
            {
                decimal itemPrice = decimal.Parse(selectedItem.SubItems[1].Text); //makes sure it gets the right subitem
                totalSelectedPrice += itemPrice;

                string itemName = selectedItem.Text;
                Item selectedOrderItem = unpaidLines.FirstOrDefault(line => line.Item.Name == itemName)?.Item; //CHATGPT GENERATED CODE.FirstOrDefault(...) is a LINQ (Language Integrated Query)
                                                                                                               //method that retrieves the first element from unpaidLines that satisfies a specified condition.
                                                                                                               //line => line.Item.Name == itemName line is said condition checking if Item.Name matches local variable itemName
                                                                                                               //?.Item ensures that if the result of FirstOrDefault is null, accessing .Item won't throw a NullReferenceException
                if (selectedOrderItem != null)
                {
                    selectedItems.Add(selectedOrderItem);
                }
            }

            txtbox_AmountToBePaid.Text = totalSelectedPrice.ToString("F2");
        }
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            Receipt receipt = FillReceipt();
            if (receipt == null)
            {
                return;
            }
            receiptList.Add(receipt);   
            RemoveSelectedItemsFromLists();
            bool checkIfAllIsPaid = CheckIfAllIsPaid();
            if (checkIfAllIsPaid)
            {
                PushReceipt(receiptList);
                SetTableFree();
                SetOrderToPaid(receipt.OrderID);
                receiptList.Clear();
                UpdateListViewAfterPayment();
                MessageBox.Show("Payment completed successfully.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SetOrderToPaid(int orderID)
        {
            OrderService orderService = new OrderService();
            orderService.SetOrderToPaid(orderID);
        }
        private bool CheckIfAllIsPaid()
        {
            if (listViewOrdersByTables.Items.Count == 0)
            {
                return true;
            }
            return false;
        }
        private void RemoveSelectedItemsFromLists()
        {
            if (listViewOrdersByTables.SelectedItems.Count > 0)
            {
                RemoveSelectedListViewItems();
            }
            else // if nothing is selected, clear only the displayed items
            {
                ClearAllDisplayedItems();
            }
        }

        private void RemoveSelectedListViewItems()
        {
            foreach (ListViewItem selectedItem in listViewOrdersByTables.SelectedItems.Cast<ListViewItem>().ToList()) //cast to list, iterates over selected items to only delete those
            {
                listViewOrdersByTables.Items.Remove(selectedItem);

                string itemName = selectedItem.Text;
                Item selectedOrderItem = selectedItems.FirstOrDefault(item => item.Name == itemName); 
                if (selectedOrderItem != null)
                {
                    unpaidLines.RemoveAll(line => line.Item == selectedOrderItem);
                    selectedItems.Remove(selectedOrderItem);
                }
            }
        }

        private void ClearAllDisplayedItems()
        {
            List<Item> itemsToRemove = new List<Item>();

            foreach (ListViewItem item in listViewOrdersByTables.Items) //iterates over all items to delete all of them (because when none are selected it assumes 1 payment is made to pay for everything
            {
                string itemName = item.Text;
                Item selectedOrderItem = selectedItems.FirstOrDefault(item => item.Name == itemName);  

                if (selectedOrderItem != null)
                {
                    unpaidLines.RemoveAll(line => line.Item == selectedOrderItem);
                    itemsToRemove.Add(selectedOrderItem);
                }
            }

            foreach (Item itemToRemove in itemsToRemove)
            {
                selectedItems.Remove(itemToRemove);
            }

            listViewOrdersByTables.Items.Clear();
            txtbox_AmountToBePaid.Text = "0";
        }


        private Receipt FillReceipt()
        {
            Receipt receipt = new Receipt();

            receipt.TotalPrice = decimal.Parse(txtbox_AmountToBePaid.Text);
            receipt.PaymentMethod = (int)(PaymentMethod)combobox_SelectPaymentMethod.SelectedItem; 
            receipt.Comment = txtbox_Comment.Text;
            receipt.EndTime = DateTime.Now;
            receipt.OrderID = int.Parse(txt_boxOrderId.Text);

            if (decimal.TryParse(txtbox_Tip.Text, out decimal tip))
            {
                if (tip > 0)
                {
                    receipt.Tip = tip;
                }
                else if (tip < 0)
                {
                    MessageBox.Show("Please enter a positive tip amount if you enter any.", "Invalid Tip Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            else
            {
                receipt.Tip = 0;
            }
            return receipt;
        }

        private void PushReceipt(List<Receipt> receipts)
        {
            ReceiptService receiptService = new ReceiptService();

            foreach (Receipt receipt in receipts)
            {
                try
                {
                    receiptService.PushReceipt(receipt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while pushing receipt: {ex.Message}");
                }
            }
        }

        private void SetTableFree()
        {
            int tableNumber = combobox_TableNumbers.SelectedIndex; 

            try
            {
                TableService tableService = new TableService();
                tableService.SetTableFree(tableNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while setting table {tableNumber} free: {ex.Message}");
            }
        }
        private void UpdateListViewAfterPayment()
        {
            listViewOrdersByTables.Items.Clear();
            txtbox_AmountToBePaid.Text = "0";
            txtbox_Comment.Text = "";

            RetrieveUnpaidOrders();
            RetrieveUnpaidLines(unpaidOrders);

            int selectedTableNumber = (int)combobox_TableNumbers.SelectedItem;
            int orderId = RetrieveOrderId(selectedTableNumber);
            List<Item> items = GetCorrespondingOrderItems(orderId);
            List<decimal> pricesWithVatSubtracted = GetPricesWithoutVat(items);
            ShowSelectedOrder(items, pricesWithVatSubtracted);
            PopulateAmountToBePaidTextbox(items);
        }
    }
}