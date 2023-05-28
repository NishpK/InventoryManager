using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO.Entities
{
    class Inventory
    {
        public int inventoryID { get; set; }   
        public string product_name { get; set; }
        public int qty { get; set; }    

        public Inventory (int inventoryID,  string product_name, int qty)
        {
            this.inventoryID = inventoryID;
            this.product_name = product_name;
            this.qty = qty;
        }
    }
}
