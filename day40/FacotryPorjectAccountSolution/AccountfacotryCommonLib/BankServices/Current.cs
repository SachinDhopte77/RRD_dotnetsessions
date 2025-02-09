using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountfacotryCommonLib.BankServices
{
    internal class Current : IBankAccount
    {
        private readonly int _accountNo;
        private readonly string _name;
        private double _balance;

        public Current(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }

        public int AccountNumber { get { return _accountNo; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        //public int AccountNumber { get; set; }
        //public string Name { get; set; }
        //public double Balance { get; set; }

        public double Diposit(double amount)
        {
            return _balance = _balance + amount;
        }

        public double Withdraw(double amount)
        {
            return _balance = _balance - amount;
        }
    }
}
