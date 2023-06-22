using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO.Entities
{
    internal class Items
    {
        public int itemID;
        public string name;
        public string brand;
        public int qty;
        public double unitPrice;

        public Items() { }

        public Items(int itemID, string name, string brand, int qty, double unitPrice)
        {
            this.itemID = itemID;
            this.name = name;
            this.brand = brand;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }

        //use this constructor during a transaction to ajudst inventory 
        public Items(int itemID, int qty) 
        { 
            this.itemID = itemID; 
            this.qty = qty; 
        }
    }
}
