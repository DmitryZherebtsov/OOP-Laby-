using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourConcepts
{
    public class Bank
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine("Your balance: " + balance + "$");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance) {
                balance -= amount;
                Console.WriteLine("You withdraw: " + amount + "$");
                //Console.WriteLine("Your balance: " + balance + "$");
            } else {
                Console.WriteLine("Not Enough Money on Your Balace!");
            }
        }
    
        public decimal GetBalance()
        {
            return balance;
        }

    }
}
