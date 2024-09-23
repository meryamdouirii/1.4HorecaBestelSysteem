using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{

    public class OrderDao : BaseDao
    {
        DateTime date = DateTime.Today;

        public void AddNewOrder(Order order)
        {
            InsertOrder(order);
            InsertOrderLines(order);
            DecreaseItemStock(order);
        }

        private void InsertOrder(Order order)
        {
            string orderQuery = "INSERT INTO [Order] (OrderTime, EndTime, TableNumber, isPayed, StateFoodID, StateDrinksID) " +
                                "OUTPUT INSERTED.OrderID " +
                                "VALUES (@OrderTime, @EndTime, @TableNumber, @isPayed, @StateFood, @StateDrinks)";
            SqlParameter[] orderParameters = new SqlParameter[]
            {
                  new SqlParameter("@OrderTime", order.OrderTime),
                  new SqlParameter("@EndTime", DBNull.Value),
                  new SqlParameter("@TableNumber", order.Table.TableNumber),
                  new SqlParameter("@isPayed", order.IsPayed),
                  new SqlParameter("@StateFood", order.StateFood != State.None ? (int)order.StateFood : DBNull.Value),
                  new SqlParameter("@StateDrinks", order.StateDrinks != State.None ? (int)order.StateDrinks : DBNull.Value)
            };
            order.OrderId = (int)ExecuteScalarQuery(orderQuery, orderParameters);
        }

        private void InsertOrderLines(Order order)
        {
            foreach (OrderLine orderLine in order.GetItems())
            {
                InsertOrderLine(orderLine, order.OrderId);
            }
        }

        private void InsertOrderLine(OrderLine orderLine, int orderId)
        {
            string orderRegelQuery = "INSERT INTO OrderLine (OrderID, ItemID, Comment, Count) " +
                                     "VALUES (@OrderID, @ItemID, @Comment, @Count)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@OrderID", orderId),
                 new SqlParameter("@ItemID", orderLine.Item.ItemId),
                 new SqlParameter("@Comment", (object)orderLine.Comment ?? DBNull.Value),
                 new SqlParameter("@Count", orderLine.Count)
            };
            ExecuteEditQuery(orderRegelQuery, parameters);
        }

        private void DecreaseItemStock(Order order)
        {
            foreach (OrderLine line in order.GetItems())
            {
                DecreaseItemStock(line.Item, line.Count);
            }
        }
        private void DecreaseItemStock(Item item, int count)
        {
            string updateQuery = "UPDATE items SET stock_amount = stock_amount - @Count WHERE item_id = @ItemID";
            SqlParameter[] updateParameters = new SqlParameter[]
            {
                   new SqlParameter("@ItemID", item.ItemId),
                   new SqlParameter("@Count", count)
            };

            ExecuteEditQuery(updateQuery, updateParameters);
        }
        public List<Order> RetrieveUnpaidOrders()
        {
            string query = "SELECT o.OrderID, o.OrderTime, o.EndTime, o.TableNumber, o.IsPayed, o.StateFoodID, o.StateDrinksID, t.IsReserved, t.Seats " +
                           "FROM [dbo].[Order] o " +
                           "JOIN [dbo].[Table] t ON o.TableNumber = t.TableNumber " +
                           "WHERE o.IsPayed = 0";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTablesUnpaidOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public void SetOrderToPaid(int orderId)
        {
            string query = "UPDATE [dbo].[order] SET IsPayed = 1 WHERE OrderID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@OrderID", orderId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        //kitchen/bar
        public List<Order> GetOrders(bool isForKitchen, State state, State state2)
        {
            string query = "SELECT DISTINCT [order].orderid, [order].ordertime, [order].Endtime, [order].Tablenumber, [order].Ispayed, [order].StatefoodID, [order].StateDrinksID " +
                           "FROM [order] " +
                           "JOIN orderline AS regel ON [order].orderId = regel.orderid " +
                           "JOIN items ON regel.itemID = items.item_id " +
                           "WHERE items.IsForKitchen = @isForKitchen " +
                           "AND ((@isForKitchen = 1 AND [order].StatefoodID IN (@State1, @State2)) " +
                           "OR (@isForKitchen = 0 AND [order].StateDrinksID IN (@State1, @State2))) " +
                           "AND [order].OrderTime >= @startDate " +
                           "AND [order].OrderTime < DATEADD(DAY, 1, @startDate) " +
                           "ORDER BY [order].OrderTime;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@isForKitchen", isForKitchen),
                new SqlParameter("@startDate", date),
                new SqlParameter("@State1", (int)state), //int ----
                new SqlParameter("@State2", (int)state2), //int -----
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters), isForKitchen);
        }

        private List<Order> ReadTablesUnpaidOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order();
                order.OrderId = (int)row["OrderID"];
                order.OrderTime = (DateTime)row["OrderTime"];

                if (row["EndTime"] != DBNull.Value)
                {
                    order.EndTime = (DateTime)row["EndTime"];
                }

                order.IsPayed = (bool)row["IsPayed"];

                if (row["StateFoodID"] != DBNull.Value)
                {
                    int stateFoodId = (int)row["StateFoodID"];
                    order.StateFood = (State)stateFoodId;
                }

                if (row["StateDrinksID"] != DBNull.Value)
                {
                    int stateDrinkId = (int)row["StateDrinksID"];
                    order.StateDrinks = (State)stateDrinkId;
                }

                int tableNumber = (int)row["TableNumber"];
                Table table = new Table
                {
                    TableNumber = tableNumber,
                    IsReserved = (bool)row["IsReserved"],
                    Seats = (int)row["Seats"]
                };
                order.Table = table;

                orders.Add(order);
            }
            return orders;
        }

        private List<Order> ReadTables(DataTable dataTable, bool IsForKitchen)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table tableObject = new Table()
                {
                    TableNumber = (int)dr["TableNumber"]
                };
                Order order = new Order()
                {
                    OrderId = (int)dr["OrderID"],
                    OrderTime = (DateTime)dr["OrderTime"],
                    EndTime = dr["EndTime"] != DBNull.Value ? (DateTime)dr["EndTime"] : DateTime.MinValue,
                    Table = tableObject,
                };
                if (IsForKitchen)
                {
                    order.StateFood = (State)(int)dr["StateFoodID"];
                }
                else
                {
                    order.StateDrinks = (State)(int)dr["StateDrinksID"];
                }
                orders.Add(order);
            }
            return orders;
        }

        public bool IsFinishedOrder(Order order)
        {
            string query = "select orderID " +
                "from [order] " +
                "where (StateFoodID IN (2,3) OR StateDrinksID IN (2,3) ) " +
                "and orderid = @orderID";
            SqlParameter[] sqlParameters = { new SqlParameter("@orderId", order.OrderId) };
            DataTable resultTable = ExecuteSelectQuery2(query, sqlParameters);
            return QueryEmpty(resultTable);
        }

        public bool QueryEmpty(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InsertEndTime(Order order)
        {
            DateTime date = DateTime.Now;
            string query = " UPDATE [order] " +
            "SET [endtime] = @date " +
            "WHERE [orderID] = @orderId;";
            SqlParameter[] sqlParameters = { new SqlParameter("@orderId", order.OrderId), new SqlParameter("@date", date) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public Order ChangeOrderState(Order order, State state, bool isForKitchen)
        {
            string query;
            if (isForKitchen)
            {
                query = "UPDATE [order] SET StateFoodID = @state WHERE orderid = @orderId;";
            }
            else
            {
                query = "UPDATE [order] SET StateDrinksID = @state WHERE orderid = @orderId;";
            }
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", order.OrderId),
                new SqlParameter("@state", (int)state)
            };
            ExecuteEditQuery(query, sqlParameters);

            if (isForKitchen)
            {
                order.StateFood = state;
            }
            else
            {
                order.StateDrinks = state;
            }
            return order;
        }

    }
}