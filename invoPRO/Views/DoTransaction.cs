﻿using invoPRO.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace invoPRO.Views
{
    public partial class DoTransaction : Form
    {
        public DoTransaction()
        {
            InitializeComponent();
            getNewTransactionID();
            salesDataGrid.Columns.Add("Index", "Index");
            salesDataGrid.Columns.Add("ItemID", "Item ID");
            salesDataGrid.Columns.Add("Quanitity", "Quanitity");
            salesDataGrid.Columns.Add("UnitPrice", "Unit Price");
            salesDataGrid.Columns.Add("TotlPrice", "Price");
        }

       void halfClear()
        {
            itemIDTxt.Text = string.Empty;
            QtyTxt.Text = string.Empty;
            PriceTxt.Text = string.Empty;
            //Add discount text box to 0
        }

        void fullclear()
        {
            Close();
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
                infoview.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }

            catch
            {

            }
        }

        void loadprice()
        {
            DBConnection Con = new DBConnection();
            try
            {

                int id = int.Parse(itemIDTxt.Text);
                try
                {
                    
                    
                    Con.connectDB();
                    SqlCommand cmd = new SqlCommand("SELECT unitPrice FROM Items WHERE ItemID = @ItemID", Con.connection);
                    cmd.Parameters.AddWithValue("@ItemID", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    

                    if (dt.Rows.Count > 0)
                    {
                        string itemName = dt.Rows[0]["unitPrice"].ToString();
                        PriceTxt.Text = itemName;
                    }

                }
                catch (System.FormatException)
                {


                }

            }

            catch
            {

            }
        }

        void getNewTransactionID()
        {
            GetInfoEvents getInfoEvents = new GetInfoEvents();
            transactionID = getInfoEvents.getTransactionID();
            transactionID++;
            transactionIDTxt.Text = transactionID.ToString();   
        }

        int[] itemIDs = new int[20];
        int[] quantities = new int[20];
        int subTransaction = 1;
        int transactionID;

        float subtotal = 0;
        float nettotal;
        float discount = 0;

        private void addItem_Click(object sender, EventArgs e)
        {

            subTransactionTxt.Text = subTransaction.ToString();
            
            int itemID = int.Parse(itemIDTxt.Text);
            int qty = int.Parse(QtyTxt.Text);
            float price = float.Parse(PriceTxt.Text);

            discount = int.Parse(discountTxt.Text);

            float totprice = (price * qty) - discount;
            string currentDateTime = DateTime.Now.ToString();

            Sales sales = new Sales(transactionID, subTransaction, itemID, qty, currentDateTime, totprice);
            SalesEvents salesEvents = new SalesEvents();

            if (salesEvents.newSales(sales)==1)
            {
                subtotal = subtotal + totprice;
                
                itemIDs[subTransaction] = itemID;
                quantities[subTransaction] = qty;

                subtotalTxt.Text = subtotal.ToString();
                halfClear();
                salesDataGrid.Rows.Add(subTransaction, itemID, qty, price, totprice);
                subTransaction++;
                subTransactionTxt.Text = subTransaction.ToString();
            }
        }

        private void revertBtn_Click(object sender, EventArgs e)
        {

            string message = "You're about to cancel the current transaction ";

            var Dialog = MessageBox.Show(message, "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dialog == DialogResult.Yes)
            {
                SalesEvents salesEvents = new SalesEvents();


                if (salesEvents.deleteSales(transactionID) == 1)
                {
                    MessageBox.Show("Transaction was deleted succesfully \n Sales page has been reset", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fullclear();
                }
            }
        }

        private void ConfirmTransaction_Click(object sender, EventArgs e)
        {
            nettotal = subtotal;

            string message = "Do you want to complete this transaction? \n Net Total = " + nettotal + " LKR";
            var Dialog = MessageBox.Show(message, "Proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dialog == DialogResult.Yes)
            {

                for (int i = 0; i < itemIDs.Length; i++)
                {
                    Items items = new Items(itemIDs[i], quantities[i]);
                    ItemEvents itemEvents = new ItemEvents();
                    itemEvents.updateTransaction(items);
                }

                MessageBox.Show("Transaction has been processed", "Inventory updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fullclear();

            }
        }

        private void DoTransaction_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void subTransactionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemIDTxt_MouseClick(object sender, MouseEventArgs e)
        {
            //item id grid 
            itemtableload();
        }

        private void itemIDTxt_MouseLeave(object sender, EventArgs e)
        { 
        

        }

        private void itemIDTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            loadprice();
        }

        private void PriceTxt_MouseClick(object sender, MouseEventArgs e)
        {
            //backup way
            loadprice();
        }
    }
}
