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
    internal class ItemEvents
    {
        DBConnection Con = new DBConnection();

        public int newItem(Items items)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("INSERT INTO Items (itemID, name, brand ,qty, unitPrice) VALUES(@id,@name,@brand,@qty,@unitP)", Con.connection);
                cmd.Parameters.AddWithValue("@id", items.itemID);
                cmd.Parameters.AddWithValue("@name", items.name);
                cmd.Parameters.AddWithValue("@brand", items.brand);
                cmd.Parameters.AddWithValue("@qty", items.qty);
                cmd.Parameters.AddWithValue("@unitP", items.unitPrice);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;
            }

            catch(Exception ex)
            {
                string message = "An error occured : " + ex.ToString();
                MessageBox.Show(message);
                return 0;
            }
        }

        //update query not complete
        public int updateItem(Items items)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("UPDATE Items SET name = @name, brand = @brand, qty = @qty, unitPrice = @unitP WHERE itemID = @id", Con.connection);
                
                cmd.Parameters.AddWithValue("@name", items.name);
                cmd.Parameters.AddWithValue("@brand", items.brand);
                cmd.Parameters.AddWithValue("@qty", items.qty);
                cmd.Parameters.AddWithValue("@unitP", items.unitPrice);
                cmd.Parameters.AddWithValue("@id", items.itemID);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;
            }

            catch (Exception ex)
            {
                string message = "An error occured : " + ex.ToString();
                MessageBox.Show(message);
              
                return 0;
            }

        }

        public int updateTransaction(Items item)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("UPDATE Items SET qty = qty - @qty where itemID = @id", Con.connection);
                cmd.Parameters.AddWithValue("@qty", item.qty);
                cmd.Parameters.AddWithValue("@id", item.itemID);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;
            }

            catch (Exception ex)
            {
                string message = "An error occured : " + ex.ToString();
                MessageBox.Show(message);
                return 0;
            }

        }

        public int deleteitem(Items items)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("DELETE FROM Items WHERE ItemID = @ItemID", Con.connection);
                cmd.Parameters.AddWithValue("@ItemID", items.itemID);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

    }
    
}
