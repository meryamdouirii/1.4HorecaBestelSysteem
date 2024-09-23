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
using System.Xml.Serialization;

namespace UI
{
    public partial class ChangeItem : Form
    {
        private Item item;
        private ItemService itemService;
        private Employee employee;
        public ChangeItem(Item item, Employee employee)
        {
            InitializeComponent();
            this.item = item;
            this.employee = employee;
            itemService = new ItemService();
            FillMenuComboBox();
            FillTypeComboBox(item.Menu);

        }
        private void FillMenuComboBox()
        {
            comboBoxMenu.DataSource = Enum.GetValues(typeof(Menu));
            comboBoxMenu.SelectedItem = item.Menu;
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
            comboBoxType.SelectedItem = item.Type;
        }
        public void Change()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text))
                {
                    item.Name = txtName.Text;
                }
                
                if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    if (decimal.Parse(txtPrice.Text) < 0)
                    {
                        MessageBox.Show("Stock can't be lower then 0");
                    }
                    else
                    {
                        item.Price = decimal.Parse(txtPrice.Text);
                    }
                    
                }
                if (!string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    if (int.Parse(txtStock.Text) < 0)
                    {
                        MessageBox.Show("Stock can't be lower then 0");
                    }
                    else 
                    {
                        item.Stock = int.Parse(txtStock.Text);
                    }
                    
                }

                if (radioBtnFood.Checked)
                {
                    item.IsForKitchen = true;
                }
                else if (radioBtnDrink.Checked)
                {
                    item.IsForKitchen = false;
                }
                if (comboBoxMenu.SelectedItem != null)
                {
                    item.Menu = (Menu)comboBoxMenu.SelectedItem;
                }
                if (comboBoxType.SelectedItem != null)
                {
                    item.Type = (ItemType)comboBoxType.SelectedItem;
                }
                if (chkBoxAlcohol.Checked)
                {
                    item.Vat = 0.21m;
                }
                else
                {
                    item.Vat = 0.09m;
                }
                DialogResult result = MessageBox.Show("Are you sure you want change the item?", "Confirm Change", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    itemService.UpdateItem(item);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            Change();
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
