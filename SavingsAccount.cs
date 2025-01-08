using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate): base(owner + "(" +interestRate +"%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Amount must be greater than zero";
            }

            decimal interestAmount = amount * InterestRate / 100;

            Balance += amount + interestAmount;
            return "Amount deposited successfully";
        }
    }
}
