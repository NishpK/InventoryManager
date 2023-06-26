using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace invoPRO
{
    public partial class SupplierView : Form
    {


        public SupplierView()
        {
            InitializeComponent();
            tableload();
            instructiontext();


        }

        void instructiontext()
        {
            search.Text = "Enter Supply Item";

        }

        void clearTxtBoxes()
        {
            sid.Text = string.Empty;
            sname.Text = string.Empty;
            pname.Text = string.Empty;
            saddress.Text = string.Empty;
            stel.Text = string.Empty;
            tableload();
        }

   
        void tableload()
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
                usersgv.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }

        void searchtableload()
        {
            string product = search.Text;
            //clear datagrid
            usersgv.DataSource = null;
            usersgv.Rows.Clear();
            usersgv.Columns.Clear();
            DBConnection Con = new DBConnection();
            Con.connectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SupplierTbl WHERE Sproduct= @Sproduct", Con.connection);
            cmd.Parameters.AddWithValue("@Sproduct", product);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            usersgv.DataSource = dt;

            Con.closeConnectDB();
        }

        void Guselect()
        {
            sid.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            sname.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            pname.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            saddress.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
            stel.Text = usersgv.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           Guselect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = sid.Text;
            string name = sname.Text;
            string item= pname.Text;
            string address = saddress.Text;
            string telnumber = stel.Text;

            Supplier supplier= new Supplier(id,name,item,address, telnumber);
            SupplierEvents supplierEvents = new SupplierEvents();

            if (supplierEvents.RegisterSupplier(supplier)==1)
            {
                clearTxtBoxes();
                MessageBox.Show("User Successfully Added");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id=sid.Text;
            string name=sname.Text;
            string item = pname.Text;
            string address=saddress.Text;
            string telnumber=stel.Text;

            Supplier supplier = new Supplier(id ,name,item,address,telnumber);
            SupplierEvents supplierEvents = new SupplierEvents();
            

            //update
            if (sid.Text == "")
            {
                MessageBox.Show("Enter Supplier ID");
            }
            else
            {

                if(supplierEvents.UpdateSupplier(supplier) == 1)
                {
                    MessageBox.Show("Supplier has been updated");
                    clearTxtBoxes();
                }
                


            }
        }
        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            string id = sid.Text;
            string name = sname.Text;
            string item = pname.Text;
            string address = saddress.Text;
            string telnumber = stel.Text;

            
            Supplier supplier = new Supplier(id, name,item, address, telnumber);
            SupplierEvents supplierEvents = new SupplierEvents();

            if (sid.Text == "")
            {
                MessageBox.Show("Enter Customer ID");

            }
            else if(supplierEvents.DeleteSupplier(supplier)==1)
            {
                MessageBox.Show("supplier Successfully Deleted");
                clearTxtBoxes();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)

            //search button, write this so in a combo box produt would be loaded and can be searched
        {
            if (search.Text == "")
            {
                MessageBox.Show("Enter Product Name");

            }
            else
            {
                searchtableload();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearTxtBoxes();

        }

        private void search_MouseClick(object sender, MouseEventArgs e)
        {
            
            search.Text = string.Empty;
        }
    }
}

