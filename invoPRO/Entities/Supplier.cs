﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO
{
    internal class Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string item { get; set; }
        public string Address { get; set; }
        public string TelNumber { get; set; }


        public Supplier(string id) { }

        public Supplier(string id, string name,string item, string address, string telnumber) 
        { 
            this.Id = id;
            this.Name= name;
            this.item = item;
            this.Address = address;
            this.TelNumber = telnumber;
        
        }


    }
}
