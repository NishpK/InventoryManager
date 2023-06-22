using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO.Events
{
    internal class GetInfoEvents
    {
        DBConnection Con = new DBConnection();
        public int getTransactionID()
        {
            int maxValue;
            try
            {
                Con.connectDB();
                string sqlQuery = "SELECT MAX(transactionID) FROM Sales";
                using (SqlCommand command = new SqlCommand(sqlQuery, Con.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxValue= Convert.ToInt32(result);
                    }
                    
                    else
                    {
                        maxValue = 0;
                    }
                }
                Con.closeConnectDB();
                return maxValue;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
    }
}
