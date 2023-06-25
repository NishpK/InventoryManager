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
using invoPRO.Entities;
using System.Security.Cryptography.X509Certificates;

namespace invoPRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

           
        private void Form1_Load(object sender, EventArgs e)
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

        //log in 
        private void button1_Click(object sender, EventArgs e)
        {


            string username = unametb.Text;
            string password= passwordtb.Text;

            if (username == "admin" && password == "123")
            {
                adminCheck.isAdmin = true;
                AdminView home = new AdminView();
                home.Show();
                this.Hide();

            }

            else
            {
                adminCheck.isAdmin = false;
                username = unametb.Text;
                password = passwordtb.Text;

               UserEvents userEvents = new UserEvents();
                if(userEvents.LoginUser(username, password) == 1)
                {
                    AdminView home = new AdminView();
                    home.Show();
                    this.Hide();
                    MessageBox.Show("Welcome " + username + "!", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Incorrect username or password");
                }

            }
        }

    }
}
