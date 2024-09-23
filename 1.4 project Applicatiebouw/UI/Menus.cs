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
    public partial class Menus : Form
    {
        public ItemService itemService;
        private List<Item> items;
        private Employee employee;
        public Menus(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            itemService = new ItemService();
            GetAllItems();

        }
        public void GetAllItems()
        {
            items = itemService.GetAllItems();
        }
        public void ShowMenu(Menu menu)
        {
            List<Item> items = ItemsMenu(menu);
            DisplayItems(items);
        }
        public List<Item> ItemsMenu(Menu menu)
        {
            List<Item> itemsPerMenu = new List<Item>();
            foreach (Item item in items)
            {
                if (item.Menu == menu)
                {
                    itemsPerMenu.Add(item);
                }
            }
            return itemsPerMenu;
        }
        private void DisplayItems(List<Item> items)
        {
            lsvItemMenu.Font = new Font("Arial", 15, FontStyle.Regular);
            lsvItemMenu.Clear();
            lsvItemMenu.Columns.Clear();
            lsvItemMenu.CheckBoxes = true;
            lsvItemMenu.View = View.Details;
            lsvItemMenu.Columns.Add("name", 200, HorizontalAlignment.Left);
            lsvItemMenu.Columns.Add("Price", 120, HorizontalAlignment.Left);
            lsvItemMenu.Columns.Add("Stock", 100, HorizontalAlignment.Left);

            ItemType savedItemType = ItemType.unknown;
            foreach (Item item in items)
            {

                ListViewItem listViewItem = new ListViewItem(item.Name)
                {
                    Tag = item
                };
                listViewItem.SubItems.Add(item.Price.ToString("C"));
                listViewItem.SubItems.Add(item.Stock.ToString());
                lsvItemMenu.Items.Add(listViewItem);
            }
        }
        private ListViewItem GetSelectedListViewItem()
        {
            if (!(lsvItemMenu.CheckedItems.Count == 1))
            {
                throw new Exception("Select only one item to delete or change");
            }
            else
            {
                return lsvItemMenu.CheckedItems[0];
            }
        }
        public void DeleteItem()
        {
            try
            {
                ListViewItem itemToDelete = GetSelectedListViewItem();
                if (itemToDelete == null)
                {
                    MessageBox.Show("Please select an item to delete.");
                    return;
                }
                Item item = (Item)itemToDelete.Tag;
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        lsvItemMenu.Items.Remove(itemToDelete);
                        items.Remove(item);
                        itemService.DeleteItem(item);
                
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void AddItemToListView(Item item) 
        {
            items.Add(item);
        }
        public void AddItem()
        {
            try
            {
                if (lsvItemMenu.CheckedItems.Count >= 1)
                {
                    throw new Exception("Please deselect all items before adding a new one.");
                }

                AddItem addItemForm = new AddItem(this, employee);
                addItemForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Add Item", MessageBoxButtons.OK);
            }
        }
        public void ChangeItem()
        {
            try
            {
                ListViewItem itemToChange = GetSelectedListViewItem();
                if (itemToChange == null)
                {
                    MessageBox.Show("Please select an item to change.");
                    return;
                }
                Item item = (Item)itemToChange.Tag;
                DialogResult result = MessageBox.Show("Are you sure you want to change the selected item?", "Confirm to make changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ChangeItem changeItem = new ChangeItem(item, employee);
                    changeItem.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Back()
         {
             this.Hide();
             ManagerMenuForm ManagerMenuForm = new ManagerMenuForm(employee);
             ManagerMenuForm.ShowDialog();
             this.Close();
        }
        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void drinkMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenu(Menu.Drink);
        }

        private void lunchMenuTSMI_Click(object sender, EventArgs e)
        {
            ShowMenu(Menu.Lunch);
        }

        private void dinnerMenuTSMI_Click(object sender, EventArgs e)
        {
            ShowMenu(Menu.Dinner);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangeItem();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverView overView = new OverView();
            overView.ShowDialog();
        }
    }
}
