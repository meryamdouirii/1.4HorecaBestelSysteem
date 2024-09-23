using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = "SELECT Tablenumber, Isreserved, seats from [table]";
            SqlParameter[] sqlParameters = new SqlParameter[0]; //passes an empty array of SqlParameter objects, so you can call methods that require them even if you dont have parameters to pass
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Table> GetSeatedTables()
        {
            string query = "SELECT Tablenumber, Isreserved, seats from [table] WHERE IsReserved = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> Tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table Table = new Table()
                {
                    TableNumber = (int)dr["TableNumber"],
                    IsReserved = (bool)dr["IsReserved"],
                    Seats = (int)dr["seats"]
                };
                Tables.Add(Table);
            }
            return Tables;
        }

        public void UpdateTableReservation(Table table)
        {
            string query;
            if (table.IsReserved == true)
            {
                query = "Update [table] set IsReserved = 0 where Tablenumber = @tablenumber";
            }
            else
            {
                query = "Update [table] set IsReserved = 1 where Tablenumber = @tablenumber";
            }
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tablenumber", SqlDbType.Int);
            sqlParameters[0].Value = table.TableNumber;

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<WaitingTime> GetWaitingTime(Table table)
        {
            DateTime today = DateTime.Today;
            string query = "SELECT o.ordertime FROM [order] AS o JOIN [table] AS t ON o.tablenumber = t.tablenumber " +
                "WHERE o.tablenumber = @tablenumber and o.EndTime is NULL and o.Ordertime >= @today;";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tablenumber", SqlDbType.Int);
            sqlParameters[0].Value = table.TableNumber;
            sqlParameters[1] = new SqlParameter("@today", SqlDbType.Date);
            sqlParameters[1].Value = today;
            return ReadWaitingTime(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<WaitingTime> ReadWaitingTime(DataTable dataTable)
        {
            List<WaitingTime> WaitingTimes = new List<WaitingTime>();

            foreach (DataRow dr in dataTable.Rows)
            {
                WaitingTime WaitingTime = new WaitingTime()
                {
                    Starttime = (DateTime)dr["ordertime"]
                };
                WaitingTimes.Add(WaitingTime);
            }
            return WaitingTimes;
        }
        public void SetTableFree(int tableNumber)
        {
            string query = "UPDATE [dbo].[table] SET IsReserved = 0 WHERE tableNumber = @TableNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", SqlDbType.Int);
            sqlParameters[0].Value = tableNumber;

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
