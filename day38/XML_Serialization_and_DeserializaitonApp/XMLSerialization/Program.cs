
using System.Xml.Serialization;
using XMLCommonLib;

namespace XMLSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\lIvesessionkoenig\\RRD\\C#.Net\\DataFile\\day38\\Data\\Test.Xml";
            SerializeToXML(filePath);
        }

        private static void SerializeToXML(string filePath)
        {
            
            Customer cust1= new Customer{Id=3,Name="Sachin",
                Addresses=new List<Address> { new Address { City = "Mumbai", Country = "India" },
                new Address{City="Ratnagiri",Country="India"} } };

            XmlSerializer serializer = new XmlSerializer(typeof(Customer));        
            StreamWriter writer = new StreamWriter(filePath);
            serializer.Serialize(writer,cust1);
            writer.Close();
            Console.WriteLine("Xml is generated.");
        }
    }
}
