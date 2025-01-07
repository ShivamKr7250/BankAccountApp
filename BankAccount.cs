using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Amount must be greater than zero";
            }
            Balance += amount;
            return "Amount deposited successfully";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Amount must be greater than zero";
            }
            if (Balance < amount)
            {
                return "Insufficient funds";
            }
            Balance -= amount;
            return "Amount withdrawn successfully";
        }

    }
}
