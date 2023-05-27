using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using invoPRO.Events;

namespace invoPRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //database connect
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked== true) {
                passwordtb.UseSystemPasswordChar = false;

            }
            else
            {
                passwordtb.UseSystemPasswordChar=true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unametb.Text = string.Empty;
            passwordtb.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //log in 
            String username, password;

            username = unametb.Text;
            password= passwordtb.Text;


            if (username == "admin" && password == "123")
            {
                Admin_home home = new Admin_home();
                home.Show();
                this.Hide();
                MessageBox.Show("welcome admin");
            }

            else
            {
               UserEvents userEvents = new UserEvents();
                if(userEvents.LoginUser(username, password) == 1)
                {
                    Admin_home home = new Admin_home();
                    home.Show();
                    this.Hide();
                    MessageBox.Show("welcome user");
                }

                else
                {
                    MessageBox.Show("Incorrect username or password");
                }

            }

        }
    }
}
