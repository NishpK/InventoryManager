using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO.Entities
{
    internal class Sales
    {
        public int transactionID;
        public int subTrasactionID;
        public int itemID;
        public int quanity;
        public string datetime;
        public float price;

        public Sales() { }

        public Sales(int transactionID, int subTrasactionID, int itemID, int quanity, string datetime, float price)
        {
            this.transactionID = transactionID;
            this.subTrasactionID = subTrasactionID;
            this.itemID = itemID;
            this.quanity = quanity;
            this.datetime = datetime;
            this.price = price;
        }
    }

}
