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
    public partial class AddItem : Form
    {
        private Employee employee;
        private ItemService itemService;
        private Item item;
        private Menus menuForm;
        public AddItem(Menus menuForm, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            itemService = new ItemService();
            item = new Item();
            this.menuForm = menuForm;
            FillMenuComboBox();
            FillTypeComboBox(item.Menu);

        }
        private void FillMenuComboBox()
        {
            comboBoxMenu.DataSource = Enum.GetValues(typeof(Menu));
            //comboBoxMenu.SelectedItem = item.Menu;
        }

        private void FillTypeComboBox(Menu menuType)
        {
            List<ItemType> filteredItemTypes = new List<ItemType>();

            if (menuType == Menu.Lunch || menuType == Menu.Dinner)
            {
                filteredItemTypes.Add(ItemType.Starter);
                filteredItemTypes.Add(ItemType.Main);
                filteredItemTypes.Add(ItemType.Dessert);
                filteredItemTypes.Add(ItemType.Intermediate);
            }
            else if (menuType == Menu.Drink)
            {
                filteredItemTypes.Add(ItemType.SoftDrinks);
                filteredItemTypes.Add(ItemType.Beer);
                filteredItemTypes.Add(ItemType.Wine);
                filteredItemTypes.Add(ItemType.Spirits);
                filteredItemTypes.Add(ItemType.TeaAndCoffee);
            }

            comboBoxType.DataSource = filteredItemTypes;
            //comboBoxType.SelectedItem = item.Type;
        }
        public void Add()
        {
            try
            {
                bool AllfieldFilledIn = true;
                if (!string.IsNullOrWhiteSpace(txtName.Text))
                {
                    item.Name = txtName.Text;
                }
                else
                {
                    AllfieldFilledIn = false;
                }
                if (int.Parse(txtPrice.Text) < 0)
                {
                    MessageBox.Show("Stock can't be lower then 0");
                }
                else if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    item.Price = decimal.Parse(txtPrice.Text);
                }
                else
                {
                    AllfieldFilledIn = false;
                }
                if (int.Parse(txtStock.Text) < 0)
                {
                    MessageBox.Show("Stock can't be lower then 0");
                }
                else if (!string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    item.Stock = int.Parse(txtStock.Text);
                }
                else
                {
                    AllfieldFilledIn = false;
                }
                if (radioBtnFood.Checked)
                {
                    item.IsForKitchen = true;
                }
                else if (radioBtnDrink.Checked)
                {
                    item.IsForKitchen = false;
                }
                else
                {
                    AllfieldFilledIn = false;
                }
                if (comboBoxMenu.SelectedItem != null)
                {
                    item.Menu = (Menu)comboBoxMenu.SelectedItem;
                }
                else
                {
                    AllfieldFilledIn = false;
                }
                if (comboBoxType.SelectedItem != null)
                {
                    item.Type = (ItemType)comboBoxType.SelectedItem;
                }
                else
                {
                    AllfieldFilledIn = false;
                }
                if (chkBoxAlcohol.Checked)
                {
                    item.Vat = 0.21m;
                }
                else
                {
                    item.Vat = 0.09m;
                }
                if (AllfieldFilledIn == true)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want add the item?", "Confirm to add", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        itemService.AddItem(item);
                        menuForm.AddItemToListView(item);
                        MessageBox.Show("Item added successfully.");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Not all fields filled in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Menu selectedMenu = (Menu)comboBoxMenu.SelectedItem;
            FillTypeComboBox(selectedMenu);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
