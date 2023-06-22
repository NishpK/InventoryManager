using invoPRO.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO
{
    internal class InventoryInEvents
    {

        DBConnection Con = new DBConnection();

        public int neworder(InventoryIn inventoryIn)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("INSERT INTO InventoryIn (InventoryInID, subTrasactionID, ItemID, SupplierID, Qty ,DateTime) VALUES(@InventoryInID,@SubTransactionID,@ItemID,@SupplierID, @Qty ,@DateTime)", Con.connection);
                cmd.Parameters.AddWithValue("@InventoryInID", inventoryIn.InventoryInID);
                cmd.Parameters.AddWithValue("@subTransactionID", inventoryIn.subTrasactionID);
                cmd.Parameters.AddWithValue("@ItemID", inventoryIn.itemID);
                cmd.Parameters.AddWithValue("@SupplierID", inventoryIn.supplierID);
                cmd.Parameters.AddWithValue("@Qty", inventoryIn.quanity);
                cmd.Parameters.AddWithValue("@DateTime", inventoryIn.datetime);

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

        public int deleteorder(int inventoryInID)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("DELETE FROM InventoryIn WHERE InventoryInID = @InventoryInId", Con.connection);
                cmd.Parameters.AddWithValue("@InventoryInID", inventoryInID);
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
