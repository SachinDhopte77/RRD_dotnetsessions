using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountfacotryCommonLib.BankServices
{
    public class BankAccountFactory
    {
        public IBankAccount Account(AccountType accountType)
        {
            if (accountType == AccountType.Saving)
            {
             return   new Saving(1001, "Sachin", 50000);

            }
            return new Current(1002, "Akhilesh", 100000);
        }
    }
}
