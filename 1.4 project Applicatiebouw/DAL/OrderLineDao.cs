using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace DAL
{
    public class OrderLineDao : BaseDao
    {
        DateTime date = DateTime.Today;

        //(kithcen/bar View)
        public List<OrderLine> GetKitchenItemsForOrder(bool isForKitchen, State state1Order, State state2Order, ItemType itemType, Order order)
        {
            string query = "Select [order].orderid, line.itemid, line.comment, line.[count], items.[name], [type].[type_id], items.IsForKitchen, line.[count] " +
                "from [order] " +
                "join orderline AS line on [line].orderid = [order].orderid " +
                "join items ON [items].item_id = line.itemID " +
                "join type on [type].type_id = items.type_id " +
                "Where items.IsForKitchen = @isForKitchen " +
                "AND [type].[type_id] = @itemType " +
                "AND [order].orderID = @orderid " +
                           "AND ((@isForKitchen = 1 AND [order].StatefoodID IN (@State1, @State2)) " +
                           "OR (@isForKitchen = 0 AND [order].StateDrinksID IN (@State1, @State2))) " +
                           "AND [order].OrderTime >= @startDate " +
                           "AND [order].OrderTime < DATEADD(DAY, 1, @startDate) " +
                           "ORDER BY [order].OrderTime;";
            SqlParameter[] sqlParameters =
{
                new SqlParameter("@isForKitchen", isForKitchen),
                new SqlParameter("@startDate", date),
                new SqlParameter("@State1", (int)state1Order), //int ----
                new SqlParameter("@State2", (int)state2Order), //int -----
                new SqlParameter("@itemType", (int)itemType),
                new SqlParameter("@orderid", order.OrderId),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderLine> GetBarItemsForOrder(bool isForKitchen, State state1Order, State state2Order, Order order)
        {
            string query = "Select [order].orderid, line.itemid, line.comment, line.[count], items.[name], [type].[type_id], items.IsForKitchen " +
                "from [order] " +
                "join orderline AS line on [line].orderid = [order].orderid " +
                "join items ON [items].item_id = line.itemID " +
                "join type on [type].type_id = items.type_id " +
                "Where items.IsForKitchen = @isForKitchen " +
                "AND [order].orderID = @orderid " +
                             "AND ((@isForKitchen = 1 AND [order].StatefoodID IN (@State1, @State2)) " +
                             "OR (@isForKitchen = 0 AND [order].StateDrinksID IN (@State1, @State2) ))" +
            "AND [order].OrderTime >= @startDate " +
            "AND [order].OrderTime < DATEADD(DAY, 1, @startDate) " +
            "ORDER BY [order].OrderTime;";
            SqlParameter[] sqlParameters =
{
                        new SqlParameter("@isForKitchen", isForKitchen),
                        new SqlParameter("@startDate", date),
                        new SqlParameter("@State1", (int)state1Order), //int ----
                        new SqlParameter("@State2", (int)state2Order), //int -----
                        new SqlParameter("@orderid", order.OrderId),
                    };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderLine> ReadTables(DataTable dataTable)
        {
            List<OrderLine> Items = new List<OrderLine>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    ItemId = (int)dr["itemid"],
                    Name = dr["name"].ToString(),
                    Type = (ItemType)dr["type_id"], //(ItemType)dr["type_id"] = int ---------
                    IsForKitchen = (bool)dr["isforkitchen"],
                };

                OrderLine orderregel = new OrderLine()
                {
                    Comment = dr["Comment"].ToString(),
                    Item = item,
                    Count = (int)dr["count"],
                };
                Items.Add(orderregel);
            }
            return Items;
        }





        public List<OrderLine> RetrieveOrderLines(int orderId)
        {
            string query = "SELECT ItemID, Count, OrderID, Comment FROM OrderLine WHERE orderId = @OrderID";
            SqlParameter sqlParameter = new SqlParameter("@OrderID", orderId);

            return ReadTablesUnpaidOrderLines(ExecuteSelectQuery(query, sqlParameter), orderId);
        }
        private List<OrderLine> ReadTablesUnpaidOrderLines(DataTable dataTable, int orderId)
        {
            List<OrderLine> orderLines = new List<OrderLine>();

            foreach (DataRow row in dataTable.Rows)
            {
                int itemId = (int)row["ItemID"];
                Item item = GetItemDetails(itemId);

                OrderLine orderLine = new OrderLine(item)
                {
                    Count = (int)row["Count"],
                    OrderID = orderId,
                    Comment = row["Comment"] != DBNull.Value ? row["Comment"].ToString() : string.Empty, //checks if null, if not assigns it. If it is assigns empty string
                };

                orderLines.Add(orderLine);
            }

            return orderLines;
        }
        private Item GetItemDetails(int itemId)
        {
            string query = "SELECT name, price, vat, menu_id, type_id, stock_amount, IsForKitchen FROM items WHERE item_Id = @item_id";
            SqlParameter sqlParameter = new SqlParameter("@item_id", itemId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameter);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0]; //retrieves first row of the dataTable
                Item item = new Item
                {
                    ItemId = itemId,
                    Name = row["name"].ToString(),
                    Price = (decimal)row["price"],
                    Vat = (decimal)row["vat"],
                    Stock = (int)row["stock_amount"],
                    IsForKitchen = (bool)row["IsForKitchen"],
                    Menu = (Menu)(int)row["menu_id"], 
                    Type = (ItemType)(int)row["type_id"]
                };

                return item;
            }
            return null;
        }
    }
}
