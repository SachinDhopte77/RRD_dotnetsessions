using SRPApp.Models;

namespace SRPApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice", 100, .50);
            string printInvoice = invoice.PrintInvoice();
            Console.WriteLine(printInvoice);
        }
    }
}
