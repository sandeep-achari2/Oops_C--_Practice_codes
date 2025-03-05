using OOPSPracticeSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class BankAccount1
    {
        private decimal balance;
        public BankAccount1(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                Console.WriteLine("Initial balance must be greater than zero.");
            }
            else
            {
                balance = initialBalance;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}, new balance is {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew {amount}, new balance is {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds....");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }
        public decimal GetBalance() {
            return balance;
        }
    }
}
