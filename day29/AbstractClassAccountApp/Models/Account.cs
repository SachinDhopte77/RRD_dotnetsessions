using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAccountApp.Models
{
    abstract class Account
    {
        private readonly string _name;
        private readonly int _accountNo;
        protected double _balance;

        protected Account(string name, int accountNo, double balance)
        {
            _name = name;
            _accountNo = accountNo;
            _balance = balance;
        }

        public string Name { get { return _name; } }
        public int AccountNo { get { return _accountNo; } }
        public double Balance { get { return _balance; } }

        public double diposit(double amount)
        {
            return _balance += amount;
        }

        public abstract double Withdraw(double amount);

    }
}
