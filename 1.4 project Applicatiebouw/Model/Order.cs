using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private List<OrderLine> items;
        public int OrderId; 
        public DateTime OrderTime;
        public DateTime EndTime;
        public Table Table;
        public bool IsPayed;
        public State StateFood;
        public State StateDrinks;


        public TimeSpan WaitTime
        {
            get
            {
                return DateTime.Now - OrderTime;
            }
        }

        public Order(Table table, List<OrderLine> items)
        {
            this.Table = table;
            this.items = items;
            OrderTime = DateTime.Now;
            IsPayed = false;
            SetState(items);
        }

        private void SetState(List<OrderLine> items)
        {
            bool hasFood = false;
            bool hasDrinks = false;
            foreach (OrderLine line in items)
            {
                if (line.Item.Menu == Menu.Dinner || line.Item.Menu == Menu.Lunch)
                {
                    hasFood = true;
                }
                else
                {
                    hasDrinks = true;
                }
                if (hasFood && hasDrinks)
                {
                    break;
                }
            }
            StateFood = hasFood ? State.NotStarted : State.None;
            StateDrinks = hasDrinks ? State.NotStarted : State.None;
        }
        public Order() { } //constructor for DAL
      

        public List<OrderLine> GetItems()
        {
            return items;
        }

   

    }
}
