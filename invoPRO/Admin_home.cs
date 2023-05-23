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

        
        private void button1_Click(object sender, EventArgs e)
        {
          /*  // to generate from through panels
            user_manage m = new user_manage() { TopLevel = false, TopMost = true };
            m.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(m);
            m.Show();*/
          user_manage m= new user_manage();
            m.Show();

            
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
           /* //customer pg panel generate
            customer c = new customer() { TopLevel = false, TopMost = true };
            c.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(c);
            c.Show();*/

            customer c= new customer();
            c.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //supplieer manage button
            Supplier s = new Supplier();
            s.Show();
        }
    }
}