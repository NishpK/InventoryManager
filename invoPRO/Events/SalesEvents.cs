using invoPRO.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO.Events
{
    internal class SalesEvents
    {
        DBConnection Con = new DBConnection();

        public int newSales(Sales sales)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("INSERT INTO Sales (TransactionID, subTrasactionID, ItemID, Qty ,DateTime, Price) VALUES(@transactionID,@subTransactionID,@ItemID, @Qty ,@DateTime, @Price)", Con.connection);
                cmd.Parameters.AddWithValue("@transactionID", sales.transactionID);
                cmd.Parameters.AddWithValue("@subTransactionID", sales.subTrasactionID);
                cmd.Parameters.AddWithValue("@ItemID", sales.itemID);
                cmd.Parameters.AddWithValue("@Qty", sales.quanity);
                cmd.Parameters.AddWithValue("@DateTime", sales.datetime);
                cmd.Parameters.AddWithValue("@Price", sales.price);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return 0;
            }
        }

        public int deleteSales(int transactionID)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("DELETE FROM Sales WHERE TransactionID = @Sid", Con.connection);
                cmd.Parameters.AddWithValue("@Sid", transactionID);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

    }
}
