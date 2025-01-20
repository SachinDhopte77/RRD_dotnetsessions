using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppUsingthisPointer.Models
{
    internal class Account
    {
        private readonly string name;
        private readonly int accountNumber;
        private double accountBalance;

        public Account(string name, int accountNumber, double accountBalance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }

        public string Name { get { return name; } }

        public int AccountNumber { get { return accountNumber; } }

        public double AccountBalance { get { return accountBalance; } }



        public void Deposit(double amount)
        {
            accountBalance = accountBalance + amount;
        }
        public void Withdraw(double amount)
        {
            accountBalance = accountBalance - amount;
        }

        public void DoTransfer(Account account2, double transferAmount)
        {
            this.Withdraw(transferAmount);
            account2.Deposit(transferAmount);

        }
    }
}
