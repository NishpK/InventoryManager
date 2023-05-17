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
    public partial class user_manage : Form
    {
        public user_manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_home ad= new Admin_home();
            ad.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
