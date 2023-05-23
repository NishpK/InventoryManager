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
    public partial class Supplier : Form
    {
        public Supplier()
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
                String Myquery = "SELECT * FROM SupplierTbl";
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

        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sid.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            sname.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            pname.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            saddress.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
            stel.Text = usersgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SupplierTbl (Sid, Sname, Sproduct, Saddress,Stel) VALUES(@Sid,@Sname,@Sproduct,@Saddress,@Stel)", Con);
                cmd.Parameters.AddWithValue("@Sid", sid.Text);
                cmd.Parameters.AddWithValue("@Sname", sname.Text);
                cmd.Parameters.AddWithValue("@Sproduct", pname.Text);
                cmd.Parameters.AddWithValue("@Saddress", saddress.Text);
                cmd.Parameters.AddWithValue("@Stel", stel.Text);
                cmd.ExecuteNonQuery();
                Con.Close();


                MessageBox.Show("supplier successfully added");
                tableload();
                //setting the textfeilds blank after datainsert
                sid.Text = string.Empty;
                sname.Text = string.Empty;
                pname.Text = string.Empty;
                saddress.Text = string.Empty;
                stel.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            if (sid.Text == "")
            {
                MessageBox.Show("Enter customer id");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE SupplierTbl SET Sname = @Sname, Sproduct = @Sproduct, Saddress=@Saddress,Stel=@Stel WHERE Sid = @Sid", Con);
                    cmd.Parameters.AddWithValue("@Sname", sname.Text);
                    cmd.Parameters.AddWithValue("@Sproduct", pname.Text);
                    cmd.Parameters.AddWithValue("@Saddress", saddress.Text);
                    cmd.Parameters.AddWithValue("@Stel", stel.Text);
                    cmd.Parameters.AddWithValue("@Sid", sid.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("supplier successfully updated");
                    tableload();
                    sid.Text = string.Empty;
                    sname.Text = string.Empty;
                    pname.Text = string.Empty;
                    saddress.Text = string.Empty;
                    stel.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //delete button

            if (sid.Text == "")
            {
                MessageBox.Show("Enter customer id");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM SupplierTbl WHERE Sid = @Sid", Con);
                    cmd.Parameters.AddWithValue("@Sid", sid.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("supplier successfully deleted");
                    tableload();
                    sid.Text = string.Empty;
                    sname.Text = string.Empty;
                    pname.Text = string.Empty;
                    saddress.Text = string.Empty;
                    stel.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
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
                MessageBox.Show("Enter product name");

            }
            else
            {
               /* try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SupplierTbl WHERE Sproduct=@Sproduct", Con);
                    cmd.Parameters.AddWithValue("@Sproduct", search.Text);

                    Con.Close();


                    tableload();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }*/

               


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {// clear button
            sid.Text = string.Empty;
            sname.Text = string.Empty;
            pname.Text = string.Empty;
            saddress.Text = string.Empty;
            stel.Text = string.Empty;

        }
    }
}

