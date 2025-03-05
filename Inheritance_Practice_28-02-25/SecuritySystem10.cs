using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public sealed class SecuritySystem10
    {
        public void AuthenticateUser(string username, string password)
        {
            Console.WriteLine($"Authenticating user: {username}");
            Console.WriteLine($"Password: {password}");
        }
    }
    public class AdvancedSecuritySystem : SecuritySystem10 
    {
        public void EnhancedSecurityCheck()
        {
            Console.WriteLine("Performing additional security checks...");
        }
    }
}