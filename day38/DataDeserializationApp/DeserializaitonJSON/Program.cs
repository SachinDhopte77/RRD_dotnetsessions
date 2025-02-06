using System.Text.Json;
using System.Text.Json.Serialization;
using DeserializationCommonLib;

namespace DeserializaitonJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\lIvesessionkoenig\RRD\C#.Net\DataFile\day38\Data\cust1.JSON");
            var stringJSON= streamReader.ReadToEnd();

            var customer=JsonSerializer.Deserialize<Customer>(stringJSON);

            Console.WriteLine("Deserialize Customer : " + customer.Name);
            Console.WriteLine("Deserialize Customer Register Addresses : " + customer.Addresses.Count);
        }
    }
}
