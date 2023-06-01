using System;
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
using System.Data.Common;

namespace invoPRO
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
            tableload();
        }

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
                DBConnection Con = new DBConnection();

                Con.connectDB();
                String Myquery = "SELECT * FROM UserTbl";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // add users into database
        private void button1_Click_1(object sender, EventArgs e)
        { 
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
        //edit user data where username=?
        private void button2_Click(object sender, EventArgs e)
        {

            string firstname = fnametb.Text;
            string lastname = lnametb.Text;
            string username = unametb.Text;
            string password = passwordtb.Text;

            User user = new User(firstname, lastname, username, password);
            UserEvents userEvents = new UserEvents();

            if(userEvents.UpdateUser(user) == 1)
            {
                MessageBox.Show("User has been updated");
                resetAndReload();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (unametb.Text == "")
            {
                MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                string username = unametb.Text;

                string message = "You are going to delete the user " + username;

                var Dialog = MessageBox.Show(message, "Deleting User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Dialog == DialogResult.Yes)
                {
                    User user = new User(username);
                    UserEvents userEvents = new UserEvents();

                    if (userEvents.DeleteUser(user) == 1)
                    {
                        MessageBox.Show("User was deleted succesfully");
                        resetAndReload();
                    }

                }
            }
        }

        // selected row of the table added to textfeilds 
        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fnametb.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            lnametb.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            unametb.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            passwordtb.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
        }

      

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {
            passwordtb.PasswordChar = '*';

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
            resetAndReload();
        }


    }
}

