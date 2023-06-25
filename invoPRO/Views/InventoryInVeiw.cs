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
            getNewTransactionID();
        }

        void halfClear()
        {
            itemidTxt.Text = string.Empty;
            supplierIDTxt.Text = string.Empty;
            QtyTxt.Text = string.Empty;

        }

        void getNewTransactionID()
        {
            GetInfoEvents getInfoEvents = new GetInfoEvents();
            transactionID = getInfoEvents.getInvertoryID();
            transactionID++;
            transactionIDTxt.Text = transactionID.ToString();
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
        void itemnameload()
        {
            //loads the item name in to item name tab from itemid entered
            try
            {
                DBConnection Con = new DBConnection();
                string name = itemnametb.Text;
                int id = int.Parse(itemidTxt.Text);
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("SELECT name FROM Items WHERE ItemID = @ItemID", Con.connection);
                cmd.Parameters.AddWithValue("@ItemID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string itemName = dt.Rows[0]["name"].ToString();
                    itemnametb.Text = itemName;
                }

            }
            catch(System.FormatException)
            {
                

            }
           
        }


        void suppliertableload()
        {

            //product suppliers load to dataGrid for user
           
            try
            {
                // database table load to the tableGV
                DBConnection Con = new DBConnection();
                try
                {
                    // Database table load to the salesDataGrid
                    Con.connectDB();
                    string productName = itemnametb.Text;
                    string Myquery = "SELECT * FROM SupplierTbl WHERE Sproduct = @Sproduct";
                    SqlCommand cmd = new SqlCommand(Myquery, Con.connection);
                    cmd.Parameters.AddWithValue("@Sproduct", productName);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    salesDataGrid.DataSource = ds.Tables[0];
                    Con.closeConnectDB();
                }
                catch
                {

                }


            }
            catch
            {

            }
        }

        
        void producttableload()
        {

            int id = int.Parse(itemidTxt.Text);
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
        int transactionID;

        private void addItem_Click(object sender, EventArgs e)
        {
            subTransactionTxt.Text = subTransaction.ToString();

            int itemID = int.Parse(itemidTxt.Text);
            int supplierID = int.Parse(supplierIDTxt.Text);
            int qty = int.Parse(QtyTxt.Text);
           
            string currentDateTime = DateTime.Now.ToString();

            InventoryIn inventoryIn = new InventoryIn(transactionID, subTransaction, itemID, supplierID, qty, currentDateTime);
            InventoryInEvents inventoryInEvents = new InventoryInEvents();

            if (inventoryInEvents.neworder(inventoryIn) == 1)
            {
                itemIDs[subTransaction] = itemID;
                quantities[subTransaction] = qty;


                halfClear();
                //salesDataGrid.Rows.Add(subTransaction, itemID, supplierID,qty);
                subTransaction++;
                subTransactionTxt.Text = subTransaction.ToString();
            }
        }

        private void revertBtn_Click(object sender, EventArgs e)
        {

        }

        private void revertBtn_Click_1(object sender, EventArgs e)
        {
            string message = "You're about to cancel the current order ";

            var Dialog = MessageBox.Show(message, "Cancel order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dialog == DialogResult.Yes)
            {
                InventoryInEvents inventoryInEvents = new InventoryInEvents();

                if (inventoryInEvents.deleteorder(transactionID) == 1)
                {
                    MessageBox.Show("Transaction was deleted succesfully \n Inventory page has been reset", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fullclear();
                }
            }
        }

        private void ConfirmTransaction_Click(object sender, EventArgs e)
        {
            string message = "Your inventory will be updated with the entered values, Do you wish to proceed?";
            var Dialog = MessageBox.Show(message, "Proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dialog == DialogResult.Yes)
            {

                for (int i = 0; i < itemIDs.Length; i++)
                {
                    Items items = new Items(itemIDs[i], quantities[i]);
                    ItemEvents itemEvents = new ItemEvents();
                    itemEvents.itemInUpdate(items);
                }

                MessageBox.Show("Transaction has been processed", "Inventory updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fullclear();
            }
        }
 

        private void itemIdTxt_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void supplierIDTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {
            //load product and quantity to the table
            //producttableload();
        }

        private void itemIdTxt_MouseClick(object sender, MouseEventArgs e)
        {
            //load all item names and item numbers to table
            itemtableload();
        }

        private void supplierIDTxt_MouseClick(object sender, MouseEventArgs e)
        {
                //load the supply details to the table once typed one letter
                suppliertableload();
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void itemidTxt_Enter(object sender, EventArgs e)
        {
            itemnameload();
        }
    }
}
