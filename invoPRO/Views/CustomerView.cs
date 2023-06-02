using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            tableload();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void tableload()
        {
            try
            {
                // database table load to the tableGV
                Con.Open();
                String Myquery = "SELECT * FROM CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                usersgv.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        void Guselect()
        {
            cid.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            cfname.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            clname.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            caddress.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
            ctel.Text = usersgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        void ResetRelaod()
        {
            tableload();
            cid.Text = string.Empty;
            cfname.Text = string.Empty;
            clname.Text = string.Empty;
            caddress.Text = string.Empty;
            ctel.Text = string.Empty;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guselect();
        }
        //add customer
        private void button1_Click(object sender, EventArgs e)
        {
            string id = cid.Text;
            string firstname = cfname.Text;
            string lastname = clname.Text;
            string address = caddress.Text;
            string tel = ctel.Text;

            Customer customer = new Customer(id, firstname, lastname, address, tel);
            CustomerEvents customerEvents = new CustomerEvents();

            if (customerEvents.Registercustermer(customer) == 1)
            {
                MessageBox.Show("user successfully added");
                ResetRelaod();
            }
            else
            {
                MessageBox.Show("error occured");
            }


        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            string id = cid.Text;
            string firstname = cfname.Text;
            string lastname = clname.Text;
            string address = caddress.Text;
            string tel = ctel.Text;

            Customer customer = new Customer(id, firstname, lastname, address, tel);
            CustomerEvents customerEvents = new CustomerEvents();
            if (cid.Text == "")
            {
                MessageBox.Show("Enter customer id");
            }
            
            else if(customerEvents.Updatecustomer(customer)==1)
            {
                MessageBox.Show("customer successfully updated");
                ResetRelaod();

            }
            else
            {
                MessageBox.Show("error occured");
            }
            

        }
        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            string id = cid.Text;
            Customer customer = new Customer(id);
            CustomerEvents customerEvents = new CustomerEvents();

            if (cid.Text == "")
            {
                MessageBox.Show("Enter customer id");

            }
            else if(customerEvents.Deletecustomer(customer)==1)
            {
              
                MessageBox.Show("customer successfully deleted");
                ResetRelaod();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetRelaod();
        }
    }
}
