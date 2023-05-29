﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using invoPRO.Entities;
using invoPRO.Events;

namespace invoPRO
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
            tableload();
        }
        //connecting the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            AdminView ad = new AdminView();
            ad.Show();
        }

        void resetAndReload()
        {
            tableload();
            fnametb.Text = string.Empty;
            lnametb.Text = string.Empty;
            unametb.Text = string.Empty;
            passwordtb.Text = string.Empty;
        }

            void tableload()
        {
            try
            {
                // database table load to the tableGV
                Con.Open();
                String Myquery = "SELECT * FROM UserTbl";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { // add users into database
            string firstName = fnametb.Text;
            string lastName = lnametb.Text;
            string username = unametb.Text;
            string password = passwordtb.Text;

            User user = new User(firstName, lastName, username, password);
            UserEvents userEvents = new UserEvents();

            if (userEvents.RegisterUser(user) == 1)
            {
                MessageBox.Show("user successfully added");
                resetAndReload();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        { // edit user data where username=?
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET FirstName = @FirstName, LastName = @LastName, Upassword = @Upassword WHERE Uname = @Uname", Con);
                cmd.Parameters.AddWithValue("@FirstName", fnametb.Text);
                cmd.Parameters.AddWithValue("@LastName", lnametb.Text);
                cmd.Parameters.AddWithValue("@Upassword", passwordtb.Text);
                cmd.Parameters.AddWithValue("@Uname", unametb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("User successfully updated");
                tableload();
                fnametb.Text = "";
                lnametb.Text = "";
                unametb.Text = "";
                passwordtb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // delete 

            if (unametb.Text == "")
            {
                MessageBox.Show("Enter username");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE Uname = @Uname", Con);
                    cmd.Parameters.AddWithValue("@Uname", unametb.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("User successfully deleted");
                    tableload();
                    fnametb.Text = "";
                    lnametb.Text = "";
                    unametb.Text = "";
                    passwordtb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }


            }
        }


        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // selected row of the table added to textfeilds 
            fnametb.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            lnametb.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            unametb.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            passwordtb.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
        }

      

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            passwordtb.PasswordChar = '*';

            // The control will allow no more than 14 characters.
            passwordtb.MaxLength = 14;
        }

        private void user_manage_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clear button 
            fnametb.Text = "";
            lnametb.Text = "";
            unametb.Text = "";
            passwordtb.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

