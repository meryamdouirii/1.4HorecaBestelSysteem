using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receipt
    {
        public int ReceiptID { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }
        public DateTime EndTime { get; set; }
        public int PaymentMethod { get; set; }
        public decimal Tip { get; set; }
        public int OrderID { get; set; }
    }
}
