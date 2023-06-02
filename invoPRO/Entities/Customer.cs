using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO
{
    internal class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public  Customer(string id,string firstName, string lastName, string address, string tel)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address= address;
            this.Tel=tel;
        }

        public Customer(string id) 
        { 
            this.Id = id;
        }




    }





}
