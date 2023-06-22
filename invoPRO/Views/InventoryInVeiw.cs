using invoPRO.Entities;
using invoPRO.Events;
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
    public partial class InventoryInVeiw : Form
    {
        public InventoryInVeiw()
        {
            InitializeComponent();
        }

        void halfClear()
        {
            itemIdTxt.Text = string.Empty;
            supplierIDTxt.Text = string.Empty;
            QtyTxt.Text = string.Empty;
            //PriceTxt.Text = string.Empty;
            //Add discount text box to 0
        }
        void itemtableload()
        {
            DBConnection Con = new DBConnection();
            try
            {
                // database table load to the tableGV
                Con.connectDB();
                String Myquery = "SELECT * FROM Items";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con.connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                salesDataGrid.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }

        void suppliertableload()
        {
            DBConnection Con = new DBConnection();
            try
            {
                // database table load to the tableGV
                Con.connectDB();
                String Myquery = "SELECT * FROM SupplierTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con.connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                salesDataGrid.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }

        void producttableload()
        {

            int id = int.Parse(itemIdTxt.Text);
            DBConnection Con = new DBConnection();
            try
            {
               
                Con.connectDB();
                String Myquery = "SELECT name,qty FROM Items ";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con.connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                salesDataGrid.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }

        void fullclear()
        {
            Close();
        }

        //to load product name when supplier id is entered
        void loadproduct()
        {

        }

        int[] itemIDs = new int[20];
        int[] quantities = new int[20];
        int subTransaction = 1;
        int InventoryInID;

        
        private void addItem_Click(object sender, EventArgs e)
        {
            subTransactionTxt.Text = subTransaction.ToString();

            int itemID = int.Parse(itemIdTxt.Text);
            int supplierID = int.Parse(supplierIDTxt.Text);
            int qty = int.Parse(QtyTxt.Text);
           
            string currentDateTime = DateTime.Now.ToString();

            InventoryIn inventoryIn = new InventoryIn(InventoryInID, subTransaction, itemID, supplierID, qty, currentDateTime);
            InventoryInEvents inventoryInEvents = new InventoryInEvents();

            if (inventoryInEvents.neworder(inventoryIn) == 1)
            {
                
                halfClear();
                salesDataGrid.Rows.Add(subTransaction, itemID, supplierID,qty);
                subTransaction++;
                subTransactionTxt.Text = subTransaction.ToString();
            }
        }

        private void revertBtn_Click(object sender, EventArgs e)
        {

        }

        private void revertBtn_Click_1(object sender, EventArgs e)
        {
            //cancel 
            string message = "You're about to cancel the current order ";

            var Dialog = MessageBox.Show(message, "Cancel order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dialog == DialogResult.Yes)
            {
                InventoryInEvents inventoryInEvents = new InventoryInEvents();

                if (inventoryInEvents.deleteorder(InventoryInID) == 1)
                {
                    MessageBox.Show("Transaction was deleted succesfully \n Sales page has been reset", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fullclear();
                }

                
            }
        }

        private void ConfirmTransaction_Click(object sender, EventArgs e)
        {
            //complete
        }

        private void itemIdTxt_TextChanged(object sender, EventArgs e)
        {
            //load all item names and item numbers to table
            itemtableload();
        }

        private void supplierIDTxt_TextChanged(object sender, EventArgs e)
        {
            //load the supply details to the table once typed one letter
            suppliertableload();
        }

        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {
            //load product and quantity to the table
            producttableload();
        }
    }
}
