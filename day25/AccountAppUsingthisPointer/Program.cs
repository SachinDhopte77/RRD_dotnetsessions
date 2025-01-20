using AccountAppUsingthisPointer.Models;

namespace AccountAppUsingthisPointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account sachinAccount = new Account("Sachin", 1001, 20000);
            Account minuAccount = new Account("Minu", 1003, 30000);

            PrintDetail(sachinAccount);
            PrintDetail(minuAccount);

            double transferAmmount = 2000;

            sachinAccount.DoTransfer(minuAccount, transferAmmount);

            PrintDetail(sachinAccount);
            PrintDetail(minuAccount);



        }

        private static void PrintDetail(Account accountDetail)
        {
            Console.WriteLine($"Account Name: {accountDetail.Name}");
            Console.WriteLine($"Account Number: {accountDetail.AccountNumber}");
            Console.WriteLine($"Account Balance: {accountDetail.AccountBalance}");
        }
    }
}
