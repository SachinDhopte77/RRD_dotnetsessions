using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAccountApp.Models
{
    internal class Saving : Account
    {
        private readonly double _minBalancelimit;
        private const double _setMinimumbalancelimit = 5000;
        public Saving(string name, int accountNo, double balance) : base(name, accountNo, balance)
        {
            _minBalancelimit = _setMinimumbalancelimit;
        }
        public double MinimumBalance { get { return _minBalancelimit; } }

        public override double Withdraw(double amount)
        {
            double BalanceCheck = _balance - amount;
            if (BalanceCheck < MinimumBalance) { throw new ArithmeticException("Withdrawal denied - Minimum balance limit is 5000"); }
            return _balance -= amount;
        }
    }
}
