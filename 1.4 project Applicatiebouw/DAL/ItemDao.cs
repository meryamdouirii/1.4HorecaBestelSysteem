using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemDao : BaseDao
    {
        public List<Item> GetItemsByMenu(Menu menu)
        {
            string query = "SELECT item_id, name, menu_id, price, vat, type_id, stock_amount, IsForKitchen FROM items WHERE menu_id = @menu_id AND IsDeleted = 0 ORDER BY name DESC";
            SqlParameter[] sqlParameters = new SqlParameter[]
               {
                    new SqlParameter("@menu_id", (int)menu),
               };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllItems() 
        {
            string query = "SELECT item_id, name, menu_id, price, vat, type_id, stock_amount, IsForKitchen FROM items WHERE IsDeleted = 0 ORDER BY type_id, menu_id";
            SqlParameter[] sqlParameters = new SqlParameter[0]; 
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    ItemId = (int)dr["item_id"],
                    Name = dr["name"].ToString(),
                    Menu = (Menu)dr["menu_id"],
                    Price = (decimal)dr["price"],
                    Vat = (decimal)dr["vat"],
                    Type = (ItemType)dr["type_id"],
                    Stock = (int)dr["stock_amount"],
                    IsForKitchen = (bool)dr["IsForKitchen"]
                };
                items.Add(item);
            }
            return items;
        }
        public void AddItem(Item item) 
        {
            string query = "INSERT INTO items (name, menu_id, price, Vat, type_id, stock_amount, IsForKitchen)" +
                "VALUES (@name, @menu_id, @price, @vat, @type_id, @stock_amount, @IsForKitchen)";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@name", item.Name),
                new SqlParameter("@menu_id", (int)item.Menu),
                new SqlParameter("@price", item.Price),
                new SqlParameter("@vat", item.Vat),
                new SqlParameter("@type_id", (int)item.Type),
                new SqlParameter("@stock_amount", item.Stock),
                new SqlParameter("@IsForKitchen", item.IsForKitchen)
            };
            ExecuteEditQuery(query, sqlParameter);
        }
        public void DeleteItem(Item item) 
        {
            string query = "UPDATE items SET IsDeleted = 1 WHERE item_id = @item_id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@item_id", item.ItemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateItem(Item item) 
        {
            string query = "UPDATE items SET name = @name, menu_id = @menu_id, price = @price, vat = @vat, type_id = @type_id, stock_amount = @stock_amount, IsForKitchen = @IsForKitchen WHERE item_id = @item_id";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@item_id", item.ItemId),
                new SqlParameter("@name", item.Name),
                new SqlParameter("@menu_id", (int)item.Menu),
                new SqlParameter("@price", item.Price),
                new SqlParameter("@vat", item.Vat),
                new SqlParameter("@type_id", (int)item.Type),
                new SqlParameter("@stock_amount", item.Stock),
                new SqlParameter("@IsForKitchen", item.IsForKitchen)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Item> TotalSoldItem()
        {
            string query = "SELECT Items.item_id, Items.name, Items.stock_amount, ISNULL(SUM(OrderLine.Count), 0) AS TotalSold,  ISNULL(SUM(OrderLine.Count * Items.Price), 0) AS TotalIncome " +
                "FROM Items " +
                "LEFT JOIN OrderLine ON Items.item_id = OrderLine.ItemID " +
                //"WHERE OrderLine.ItemID = @ItemId AND Items.name = @itemName" +
                "GROUP BY Items.item_id, Items.name, Items.stock_amount " +
                "ORDER BY TotalSold DESC;";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Item> ReadTables2(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    ItemId = (int)dr["item_id"],
                    Name = dr["name"].ToString(),
                    Stock = (int)dr["stock_amount"],
                    TotalSold = Convert.ToDecimal(dr["TotalSold"]),
                    TotalIncome = Convert.ToDecimal(dr["TotalIncome"])
                };
                items.Add(item);
            }
            return items;
        }
    }
}
