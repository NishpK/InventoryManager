using invoPRO.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO.Events
{
     class InventoryEvents
    {
        DBConnection dBConnection = new DBConnection();
        public string addInventory (Inventory inventory)
        {
            try
            {
                dBConnection.connectDB();
                SqlCommand cmd = new SqlCommand("Insert INTO InventoryTbl (inventoryID, product_name, quantity) VALUES (@inventoryID, @prodname, @quantity)", dBConnection.connection);
                cmd.Parameters.AddWithValue("@inventoryID", inventory.inventoryID);
                cmd.Parameters.AddWithValue("@prodname", inventory.product_name);
                cmd.Parameters.AddWithValue("@quantity", inventory.qty);
                cmd.ExecuteNonQuery();
                dBConnection.closeConnectDB();

                return "New invetory added under code : " + inventory.inventoryID;

            }
            catch (Exception ex) 
            {
                return ex.ToString ();
            }

        }
    }
}
