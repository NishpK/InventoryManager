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
            cid.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            cfname.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            clname.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            caddress.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
            ctel.Text = usersgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl (Id, Cfname, Clname, Caddress,Ctel) VALUES(@Id,@Cfname,@Clname,@Caddress,@Ctel)", Con);
                cmd.Parameters.AddWithValue("@Id", cid.Text);
                cmd.Parameters.AddWithValue("@Cfname", cfname.Text);
                cmd.Parameters.AddWithValue("@Clname", clname.Text);
                cmd.Parameters.AddWithValue("@Caddress", caddress.Text);
                cmd.Parameters.AddWithValue("@Ctel", ctel.Text);
                cmd.ExecuteNonQuery();
                Con.Close();


                MessageBox.Show("user successfully added");
                tableload();
                //setting the textfeilds blank after datainsert
                cid.Text = string.Empty;
                cfname.Text = string.Empty;
                clname.Text = string.Empty;
                caddress.Text = string.Empty;
                ctel.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            if (cid.Text == "")
            {
                MessageBox.Show("Enter customer id");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET Cfname = @Cfname, Clname = @Clname, Caddress=@Caddress,Ctel=@Ctel WHERE Id = @Id", Con);
                    cmd.Parameters.AddWithValue("@Cfname", cfname.Text);
                    cmd.Parameters.AddWithValue("@Clname", clname.Text);
                    cmd.Parameters.AddWithValue("@Caddress", caddress.Text);
                    cmd.Parameters.AddWithValue("@Ctel", ctel.Text);
                    cmd.Parameters.AddWithValue("@Id", cid.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("customer successfully updated");
                    tableload();
                    cid.Text = string.Empty;
                    cfname.Text = string.Empty;
                    clname.Text = string.Empty;
                    caddress.Text = string.Empty;
                    ctel.Text = string.Empty;
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

            if (cid.Text == "")
            {
                MessageBox.Show("Enter customer id");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE Id = @Id", Con);
                    cmd.Parameters.AddWithValue("@Id", cid.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("customer successfully deleted");
                    tableload();
                    cid.Text = string.Empty;
                    cfname.Text = string.Empty;
                    clname.Text = string.Empty;
                    caddress.Text = string.Empty;
                    ctel.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clear
            cid.Text = string.Empty;
            cfname.Text = string.Empty;
            clname.Text = string.Empty;
            caddress.Text = string.Empty;
            ctel.Text = string.Empty;
        }
    }
}
