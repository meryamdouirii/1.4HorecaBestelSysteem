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
    public partial class OverView : Form
    {
        private ItemService itemService;
        private Item item;
        public OverView()
        {
            InitializeComponent();
            itemService = new ItemService();
            showItems();

        }

        private void showItems()
        {
            List<Item> items = itemService.TotalSoldItem();
            FillOverView(items);

        }
        private void FillOverView(List<Item> items)
        {
            lsvOverViewItems.Font = new Font("Arial", 15, FontStyle.Regular);
            lsvOverViewItems.Clear();
            lsvOverViewItems.View = View.Details;
            lsvOverViewItems.Columns.Add("item name", 250, HorizontalAlignment.Left);
            lsvOverViewItems.Columns.Add("stock", 150, HorizontalAlignment.Left);
            lsvOverViewItems.Columns.Add("Total Sold", 150, HorizontalAlignment.Left);
            lsvOverViewItems.Columns.Add("Total Income", 150, HorizontalAlignment.Left);
            foreach (Item item in items) 
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Stock.ToString());
                listViewItem.SubItems.Add(item.TotalSold.ToString());
                listViewItem.SubItems.Add(item.TotalIncome.ToString("C"));
                lsvOverViewItems.Items.Add(listViewItem);
            }
            lsvOverViewItems.GridLines = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
