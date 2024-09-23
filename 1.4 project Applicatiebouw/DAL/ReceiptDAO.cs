using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptDAO : BaseDao
    {
        public void PushReceipt(Receipt receipt)
        {
            string query = "INSERT INTO Receipt (TotalPrice, Comment, EndTime, PaymentMethod, Tip, OrderID) VALUES (@TotalPrice, @Comment, @EndTime, @PaymentMethod, @Tip, @OrderID)";

            SqlConnection conn = OpenConnection();

            using (var transaction = conn.BeginTransaction())
            {
                using (SqlCommand comm = new SqlCommand(query, conn, transaction))
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Comment", receipt.Comment),
                new SqlParameter("@EndTime", receipt.EndTime),
                new SqlParameter("@PaymentMethod", receipt.PaymentMethod), // No need to convert, already an int
                new SqlParameter("@Tip", receipt.Tip),
                new SqlParameter("@OrderID", receipt.OrderID)
                    };
                    comm.Parameters.AddRange(sqlParameters);
                    comm.ExecuteNonQuery();
                    transaction.Commit();
                    conn.Close();
                }
            }
        }
    }
}
