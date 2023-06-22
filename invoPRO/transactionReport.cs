using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO
{
    public partial class transactionReport : Form
    {
        public transactionReport()
        {
            InitializeComponent();
            tableload();
        }

        void tableload()
        {
            try
            {
                DBConnection Con = new DBConnection();

                Con.connectDB();
                String Myquery = "SELECT * FROM Sales ORDER BY TransactionID ";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con.connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                usergv.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
