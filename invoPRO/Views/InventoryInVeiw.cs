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

namespace invoPRO
{
    public partial class InventoryInVeiw : Form
    {
        public InventoryInVeiw()
        {
            InitializeComponent();
        }

        void halfClear()
        {
            itemIdTxt.Text = string.Empty;
            supplierIDTxt.Text = string.Empty;
            QtyTxt.Text = string.Empty;
            //PriceTxt.Text = string.Empty;
            //Add discount text box to 0
        }

        void fullclear()
        {
            Close();
        }

        int[] itemIDs = new int[20];
        int[] quantities = new int[20];
        int subTransaction = 1;
        int InventoryInID;

        
        private void addItem_Click(object sender, EventArgs e)
        {
            subTransactionTxt.Text = subTransaction.ToString();

            int itemID = int.Parse(itemIdTxt.Text);
            int supplierID = int.Parse(supplierIDTxt.Text);
            int qty = int.Parse(QtyTxt.Text);
           
            string currentDateTime = DateTime.Now.ToString();

            InventoryIn inventoryIn = new InventoryIn(InventoryInID, subTransaction, itemID, supplierID, qty, currentDateTime);
            InventoryInEvents inventoryInEvents = new InventoryInEvents();

            if (inventoryInEvents.neworder(inventoryIn) == 1)
            {
                
                halfClear();
                salesDataGrid.Rows.Add(subTransaction, itemID, supplierID,qty);
                subTransaction++;
                subTransactionTxt.Text = subTransaction.ToString();
            }
        }

        private void revertBtn_Click(object sender, EventArgs e)
        {

        }

        private void revertBtn_Click_1(object sender, EventArgs e)
        {
            //cancel 
        }

        private void ConfirmTransaction_Click(object sender, EventArgs e)
        {
            //complete
        }
    }
}
