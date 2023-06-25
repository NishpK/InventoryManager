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
    public partial class ItemView : Form
    {
        public ItemView()
        {
            InitializeComponent();
            tableload();
            userTypeCheck();
        }

        void resetAndReload()
        {
            tableload();
            idtb.Text = string.Empty;
            nametb.Text = string.Empty;
            brandtb.Text = string.Empty;
            qtytb.Text = string.Empty;
            pricetb.Text = string.Empty;
        }

        public void userTypeCheck()
        {

            bool isadmin = adminCheck.isAdmin;


            if (isadmin == false)
            {

                AddBtn.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

            }
        }

        void tableload()
        {
            try
            {
                DBConnection Con = new DBConnection();

                Con.connectDB();
                String Myquery = "SELECT * FROM Items";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con.connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                usersgv.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }
        void searchtableload()
        {
            string pname = searchtb.Text;
            //clear datagrid
            usersgv.DataSource = null;
            usersgv.Rows.Clear();
            usersgv.Columns.Clear();
            DBConnection Con = new DBConnection();
            Con.connectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Items WHERE name= @name", Con.connection);
            cmd.Parameters.AddWithValue("@name", pname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            usersgv.DataSource = dt;

            Con.closeConnectDB();
        }
        //add button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int itemid = int.Parse( idtb.Text);
            string name = nametb.Text;
            string brand = brandtb.Text;
            int qty = int.Parse(qtytb.Text);
            double price = double.Parse(pricetb.Text);
            
            Items items= new Items( itemid, name, brand, qty, price);
            ItemEvents itemEvents= new ItemEvents();

            if (itemEvents.newItem(items) == 1)
            {
                MessageBox.Show("Item successfully added");
                resetAndReload();
            }

        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            int itemid = int.Parse(idtb.Text);

            Items item = new Items(itemid);
            ItemEvents itemEvents= new ItemEvents();

            if (itemEvents.updateItem(item) == 1)
            {

                MessageBox.Show("Item has been updated");
                
                resetAndReload();
            }

        }

        //clear
        private void button4_Click(object sender, EventArgs e)
        {
            resetAndReload();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            int itemid = int.Parse(idtb.Text);
           

            if (idtb.Text == "")
            {
                MessageBox.Show("Enter item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                

                string message = "You are going to delete the product id: " + itemid;

                var Dialog = MessageBox.Show(message, "Deleting item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Dialog == DialogResult.Yes)
                {
                    Items item = new Items(itemid);
                    ItemEvents itemEvents = new ItemEvents();
                    if (itemEvents.deleteitem(item) == 1)
                    {
                        MessageBox.Show("User was deleted succesfully");
                        resetAndReload();

                    }
                    

                }
            }

        }

        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtb.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            nametb.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            brandtb.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            qtytb.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
            pricetb.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string pname = searchtb.Text;
            if (pname == "")
            {
                MessageBox.Show("enter item name");
            }
            else
            {
                searchtableload();

            }
        }
    }
}
