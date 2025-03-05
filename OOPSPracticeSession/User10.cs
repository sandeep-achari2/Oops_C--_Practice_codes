using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class User10
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User10(string username, string role)
        {
            Username = username;
            Role = role;
        }

        // Virtual method for access control
        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username} has basic user access.");
        }
    }

    class Admin : User10
    {
        public Admin(string username) : base(username, "Admin") { }

        // Overriding the method for Admin-specific access
        public override void AccessControl()
        {
            Console.WriteLine($"Admin {Username} has full access to all features.");
        }
    }
    class Customer : User10
    {
        public Customer(string username) : base(username, "Customer") { }

        // Overriding the method for Customer-specific access
        public override void AccessControl()
        {
            Console.WriteLine($"Customer {Username} has limited access to features.");
        }
    }
}
