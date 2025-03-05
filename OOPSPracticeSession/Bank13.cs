using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Bank13
    {
        public string BankCustomer { get; set; }
        public double balance { get; set; }
        public static double interestRate { get; private set; } = 5.0;

        public Bank13(string bankCustomer, double balance)
        {
            BankCustomer = bankCustomer;
            this.balance = balance;
        }
        public static void SetInterestRate(double newRate)
        {
            interestRate = newRate;
        }
        public void DisplayAccounyInformation()
        {
            Console.WriteLine($"Customer: {BankCustomer}, Balance: {balance}, Interest Rate: {interestRate}%");
        }
    }
}

