using invoPRO.Entities;
using invoPRO.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoPRO.Views
{
    public partial class InventoryView : Form
    {
        public InventoryView()
        {
            InitializeComponent();
        }

        public void reset()
        {
            InventoryIDtxt.Text = string.Empty;
            ProductNametxt.Text = string.Empty;
            Quantitytxt.Text = string.Empty;    
        }


        private void Clearbtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            int inventoryID = int.Parse(InventoryIDtxt.Text);
            string productName = ProductNametxt.Text;
            int quantity = int.Parse(Quantitytxt.Text);

            Inventory inventory = new Inventory(inventoryID, productName, quantity);

            InventoryEvents inventoryEvents = new InventoryEvents();
            
            string message = inventoryEvents.addInventory(inventory);

            MessageBox.Show(message);

        }
    }
}
