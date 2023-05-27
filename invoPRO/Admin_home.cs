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
    public partial class Admin_home : Form
    {
        public Admin_home()
        {
            InitializeComponent();
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
            loadform(new user_manage());


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


            // customer c= new customer();
            //c.Show();
            loadform(new customer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //supplieer manage button
            //loadform(new Supplier());
        }
    }
}