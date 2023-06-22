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
            loadform(new WelcomeScreenView());
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


        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new UserView());


        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // exit button
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           loadform(new ItemView());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //supplieer manage button
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
    }
}