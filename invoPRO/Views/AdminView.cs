using invoPRO.Entities;
using invoPRO.Events;
using invoPRO.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            userTypeCheck();
            FormClosing += AdminView_FormClosing;
        }

        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
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


        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        public void userTypeCheck()
        {

            bool isadmin = adminCheck.isAdmin;

            if(isadmin == true)
            {
                MessageBox.Show("You Have logged in as the adminstrator!", 
                    "Admin Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                button1.Visible = false ;
                button3.Visible = false ;
                managementLbl.Visible = false ;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new UserView());
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

           loadform(new ItemView());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            loadform(new SupplierView());
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            loadform(new DoTransaction());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new InventoryInVeiw());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new transactionReport());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new inventoryInreport());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout?";
            var Dialog = MessageBox.Show(message, "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dialog == DialogResult.Yes)
            {
                adminCheck.isAdmin = false;
                Application.Restart();
            }
        }
    }
}