using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryAbstractCommonLib.AccountServices
{
    public class BankAccountFactory
    {
        public Account GenerateAccount(AccountType accountType)
        {
            if(accountType==AccountType.Saving)
            {
                return new Saving(1001, "Sachin", 5000);
            }
            return new Current(1002, "Sachin", 10000);
        }
    }
}
