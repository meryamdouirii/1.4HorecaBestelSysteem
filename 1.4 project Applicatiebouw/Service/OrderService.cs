using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class OrderService
    {
        private OrderDao orderDAO;
        private OrderLineService orderRegelService;

        public OrderService()
        {
            orderDAO = new OrderDao();
            orderRegelService = new OrderLineService();
        }
        public List<Order> RetrieveUnpaidOrders()
        {
            return orderDAO.RetrieveUnpaidOrders();
        }

        public void AddOrder(Order order)
        {
            orderDAO.AddNewOrder(order);
        }    
        public void SetOrderToPaid(int orderId)
        {
            orderDAO.SetOrderToPaid(orderId);
        }

        ///kitchen/bar view
        public List<Order> GetOrders(bool isForKitchen, State state, State state2)
        {
            return orderDAO.GetOrders(isForKitchen, state, state2);
        }

        public Order ChangeOrderState(Order order, State state, bool isForKitchen)
        {
            return orderDAO.ChangeOrderState(order, state, isForKitchen);
        }

        public void InsertEndTime(Order order)
        {
            if (orderDAO.IsFinishedOrder(order) == true)
            {
                orderDAO.InsertEndTime(order);
            }          
        }

    }
}
