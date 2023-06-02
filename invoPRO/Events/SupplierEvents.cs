using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO
{
    internal class SupplierEvents
    {

        DBConnection Con = new DBConnection();

        public int RegisterSupplier(Supplier supplier)
        {
            try
            {
                return 1;
            } catch (Exception ex)
            {
                return 0;
            }
        }

        public int UpdateSupplier(Supplier supplier)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("UPDATE SupplierTbl SET Sname = @Sname, Sproduct = @Sproduct, Saddress=@Saddress,Stel=@Stel WHERE Sid = @Sid", Con.connection);
                cmd.Parameters.AddWithValue("@Sname", supplier.Name);
                cmd.Parameters.AddWithValue("@Sproduct", supplier.Product);
                cmd.Parameters.AddWithValue("@Saddress", supplier.Address);
                cmd.Parameters.AddWithValue("@Stel", supplier.TelNumber);
                cmd.Parameters.AddWithValue("@Sid", supplier.Id);
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
    }

    
}
