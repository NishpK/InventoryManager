using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO
{
    internal class InventoryIn
    {

        public int InventoryInID;
        public int subTrasactionID;
        public int itemID;
        public int supplierID;
        public int quanity;
        public string datetime;
       

        public InventoryIn() { }

        public InventoryIn(int InventoryInID, int subTrasactionID, int itemID,int supplierID, int quanity, string datetime)
        {
            this.InventoryInID = InventoryInID;
            this.subTrasactionID = subTrasactionID;
            this.itemID = itemID;
            this.supplierID = supplierID;
            this.quanity = quanity;
            this.datetime = datetime;
           
        }
    }
}
