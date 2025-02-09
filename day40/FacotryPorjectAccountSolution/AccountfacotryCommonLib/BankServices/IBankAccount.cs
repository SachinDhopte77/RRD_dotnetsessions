using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountfacotryCommonLib.BankServices
{
    public interface IBankAccount
    {
        double Diposit(double amount);
        double Withdraw(double amount);
    }
}
