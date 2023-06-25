using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoPRO.Entities
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
      

        public User(string firstName, string lastName, string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public User(string username)
        {
            this.Username = username;
        }

        public User(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }


    }
}
