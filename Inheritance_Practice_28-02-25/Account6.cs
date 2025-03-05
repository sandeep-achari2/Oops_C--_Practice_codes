using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public class Account6
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in Account...");
        }
    }
    public class SavingsAccount : Account6
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for Savings Account...");
        }
    }
    public sealed class PremiumSavingsAccount : SavingsAccount
    {
        //public override void CalculateInterest()
        //{
        //    Console.WriteLine("Calculating interest for Premium Savings Account...");
        //}
    }
}
