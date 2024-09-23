using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Service
{
    public class OrderLineService
    {
        private OrderLineDao orderRegelDao;

        public OrderLineService()
        {
            orderRegelDao = new OrderLineDao();
        }

        //kithchen/bar view 

        public List<OrderLine> GetKitchenItemsForOrder(bool isForKitchen, State state1Order, State state2Order, ItemType itemType, Order order)
        {
            return orderRegelDao.GetKitchenItemsForOrder(isForKitchen, state1Order, state2Order, itemType, order);
        }

        public List<OrderLine> GetBarItemsForOrder(bool isForKitchen, State state1Order, State state2Order, Order order)
        {
            return orderRegelDao.GetBarItemsForOrder(isForKitchen, state1Order, state2Order, order);
        }
        public List<OrderLine> RetrieveOrderLines(int orderId)
        {
            return orderRegelDao.RetrieveOrderLines(orderId);
        }
    }
}
