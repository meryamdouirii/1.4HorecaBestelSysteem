using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Model
{
    public class OrderLine 
    {
        public Item Item { get; set; }

        public int Count { get; set; }
        public string Comment { get; set; }
        public int OrderID { get; set; }


        public OrderLine(Item item)
        {
            this.Item = item;
            Count = 1;
        }
        public OrderLine() { }
    }
}
