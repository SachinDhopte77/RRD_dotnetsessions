using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAccountApp.Models
{
    internal class Current : Account
    {
        private readonly double _minBalancelimit;
        private const double _setMinimumbalancelimit = -10000;
        public Current(string name, int accountNo, double balance) : base(name, accountNo, balance)
        {
            _minBalancelimit = _setMinimumbalancelimit;
        }

        public override double Withdraw(double amount)
        {
            double BalanceCheck = _balance - amount;
            if (BalanceCheck < MinimumBalance) { throw new ArithmeticException("Withdrawal denied - Minimum balance limit is -10000"); }
            return _balance -= amount;
        }

        public double MinimumBalance { get { return _minBalancelimit; } }
    }
}
