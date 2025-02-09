using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryAbstractCommonLib.AccountServices
{
    internal class Saving : Account
    {
        
        public Saving(int accountNo, string name, double balance) : base(accountNo, name, balance)
        {
        }

        public override double Withdraw(double amount)
        {
          return  _balance=_balance - amount;
        }
    }
}
