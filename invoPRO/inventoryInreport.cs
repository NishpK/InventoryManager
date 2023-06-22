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
    public partial class inventoryInreport : Form
    {
        public inventoryInreport()
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
                String Myquery = "SELECT * FROM InventoryIn ORDER BY InventoryInID ";
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

        private void usergv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
