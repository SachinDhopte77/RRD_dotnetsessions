using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryAbstractCommonLib.AccountServices
{
    public abstract class Account
    {
        private  int _accountNo;
        private  string _name;
        protected double _balance;

        public Account(int accountNo,string name,double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }

        public int AccountNumber { get { return _accountNo; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public double Diposit(double diposit)
        {  return _balance=_balance+diposit; }

        public abstract double Withdraw(double amount);
    }
}
