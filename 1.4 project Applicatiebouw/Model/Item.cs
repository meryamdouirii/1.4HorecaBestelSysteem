using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item 
    { 
        public int ItemId { get; set; }
        public string Name { get; set; }
        public Menu Menu { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public ItemType Type { get; set; }
        public int Stock { get; set; }
        public bool IsForKitchen { get; set; }
        public decimal TotalSold { get; set; }
        public decimal TotalIncome { get; set; }

        
    }
}
