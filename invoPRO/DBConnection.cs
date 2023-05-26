using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO
{
    class DBConnection
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        public string connectDB()
        {
            try
            {
                connection.Open();
                return "Connected succesfully";
            }
            catch (Exception ex)
            {
                //String message = ex.ToString();
                //MessageBox.Show(message);
                return ex.ToString();
            }
        }

        public string closeConnectDB()
        {
            try
            {
                connection.Close();
                return "Closed";
            }

            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }

  
}
