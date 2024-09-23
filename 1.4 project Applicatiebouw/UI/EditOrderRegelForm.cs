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
using System.Xml.Linq;

namespace UI
{
    public partial class EditOrderRegelForm : Form
    {
        private OrderLine regel;

        public EditOrderRegelForm(OrderLine regel)
        {
            InitializeComponent();
            this.regel = regel;
            InitializeValues(regel); 
        }

        private void InitializeValues(OrderLine regel)
        {
            itemNameLb.Text = regel.Item.Name;
            countNum.Value = regel.Count;
            commentTb.Text = regel.Comment;
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            CloseOK();
        }

        private void CloseOK()
        {
            try
            {
                UpdateRegel();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateRegel()
        {
            int newCount = int.Parse(countNum.Value.ToString());
            if (newCount > regel.Item.Stock)
                throw new Exception($"Ordered amount is bigger than the stock! Stock: ({regel.Item.Stock})!");
            regel.Count = newCount;
            regel.Comment = commentTb.Text;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CloseCANCEL();
        }

        private void CloseCANCEL()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}