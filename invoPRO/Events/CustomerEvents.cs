using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace invoPRO
{
    internal class CustomerEvents
    {
        DBConnection Con= new DBConnection();

        public int Registercustermer(Customer customer)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl (Id, Cfname, Clname, Caddress,Ctel) VALUES(@Id,@Cfname,@Clname,@Caddress,@Ctel)", Con.connection);
                cmd.Parameters.AddWithValue("@Id",customer.Id);
                cmd.Parameters.AddWithValue("@Cfname", customer.FirstName);
                cmd.Parameters.AddWithValue("@Clname", customer.LastName);
                cmd.Parameters.AddWithValue("@Caddress", customer.Address);
                cmd.Parameters.AddWithValue("@Ctel", customer.Tel);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;



            }
            catch (Exception ex)
            {
                return 0;
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public int Updatecustomer(Customer customer)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET Cfname = @Cfname, Clname = @Clname, Caddress=@Caddress,Ctel=@Ctel WHERE Id = @Id", Con.connection);
                cmd.Parameters.AddWithValue("@Cfname", customer.FirstName);
                cmd.Parameters.AddWithValue("@Clname", customer.LastName);
                cmd.Parameters.AddWithValue("@Caddress", customer.Address);
                cmd.Parameters.AddWithValue("@Ctel", customer.Tel);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;



            }
            catch (Exception ex)
            {
                return 0;
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public int Deletecustomer(Customer customer)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE Id = @Id", Con.connection);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();
                return 1;


            }
            catch (Exception ex)
            {
                return 0;
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
