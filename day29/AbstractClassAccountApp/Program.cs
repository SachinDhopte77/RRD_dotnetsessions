using AbstractClassAccountApp.Models;

namespace AbstractClassAccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving saving = new Saving("sachin", 1001, 5000);
            double transactionSAamount = 1000;
            saving.diposit(transactionSAamount);
            PrintDetail(saving);
            transactionSAamount = 500;
            saving.Withdraw(transactionSAamount);
            PrintDetail(saving);

            Current current = new Current("Akhilesh", 1002, 25000);
            double transactionCAamount = 5000;
            current.diposit(transactionCAamount);
            PrintDetail(current);
            transactionCAamount = 35000;
            current.Withdraw(transactionCAamount);
            PrintDetail(current);
        }

        private static void PrintDetail(Account accountType)
        {
            Console.WriteLine($"Account Name: {accountType.Name} Account No: {accountType.AccountNo} Account Balance : {accountType.Balance}");
        }
    }
}
