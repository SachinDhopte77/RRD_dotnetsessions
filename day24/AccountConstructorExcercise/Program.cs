using AccountConstructorExcercise.Models;
using System.Collections.Generic;
using System.Linq;

namespace AccountConstructorExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts sachinAccount = new Accounts("Sachin", 1001, 30000);
            Accounts akhileshAccount = new Accounts("Akhilesh", 1002, 20000);
            Accounts venkatAccount = new Accounts("Venkat", 1003, 9000);

            Accounts[] accounts = new Accounts[] { sachinAccount, akhileshAccount, venkatAccount };

            PrintRichestAccountHolderDetail(accounts);
            PrintLongestAccountHolderNames(accounts);

            int transferAmount = 400;
            TransferFund(venkatAccount, sachinAccount, transferAmount);

        }

        private static void PrintRichestAccountHolderDetail(Accounts[] accounts)
        {

            var richestAccounts = accounts.Where(x => x.AccountBalance > x.RichestAccountBalanceLimit);
            foreach (var richAccounts in richestAccounts)
            {
                Console.WriteLine("Richest Account Number is {0} and account balance is {1}", richAccounts.AccountNumber, richAccounts.AccountBalance);
            }

        }

        private static void PrintLongestAccountHolderNames(Accounts[] accounts)
        {
            var lonestAccountName = accounts.Where(s => s.Name.Length > s.NameLengthLimit);
            foreach (var longestName in lonestAccountName)
            {
                Console.WriteLine("Longest Name in Accountholder list is :{0}", longestName.Name);
            }

        }

        private static void TransferFund(Accounts account1, Accounts account2, double transferAmount)
        {
            PrintDetail(account1);
            PrintDetail(account2);
            Accounts.Transfer(account1, account2, transferAmount);
            PrintDetail(account1);
            PrintDetail(account2);
        }

        private static void PrintDetail(Accounts account)
        {
            Console.WriteLine("Account Balance of {0} is {1}", account.Name, account.AccountBalance);
        }

    }
}
