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
            // to generate from through panels
            user_manage m = new user_manage() { TopLevel = false, TopMost = true };
            m.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(m);
            m.Show();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}