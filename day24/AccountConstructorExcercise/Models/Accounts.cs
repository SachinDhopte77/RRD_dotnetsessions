using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConstructorExcercise.Models
{
    class Accounts
    {
        private readonly string _name;
        private readonly int _accountNumber;
        private double _accountBalance;
        private readonly double _richectAccountbalance;
        private readonly int _longestNamelengthlimit;

        private const double richestaccountMimimumbalance = 10000;
        private const int longestNamelengthlimit = 6;


        public Accounts(string name, int accountNumber, double accountBalance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _accountBalance = accountBalance;
            _richectAccountbalance = richestaccountMimimumbalance;
            _longestNamelengthlimit = longestNamelengthlimit;

        }


        public string Name { get { return _name; } }

        public int AccountNumber { get { return _accountNumber; } }

        public double AccountBalance { get { return _accountBalance; } }

        public double RichestAccountBalanceLimit { get { return _richectAccountbalance; } }

        public int NameLengthLimit { get { return _longestNamelengthlimit; } }

        public void Deposit(double amount)
        {

            _accountBalance = _accountBalance + amount;
        }

        public void Withdraw(double amount)
        {
            _accountBalance = _accountBalance - amount;

        }
        public static void Transfer(Accounts account1, Accounts account2, double amount)
        {
            account1.Withdraw(amount);
            account2.Deposit(amount);
        }


    }
}
