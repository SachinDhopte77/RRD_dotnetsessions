
using System.Runtime.Serialization.DataContracts;
using System.Xml.Serialization;
using XMLCommonLib;

namespace XMLDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath= "C:\\lIvesessionkoenig\\RRD\\C#.Net\\DataFile\\day38\\Data\\Test.Xml";
            DeserializeFromXML(filePath);
        }

        private static void DeserializeFromXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));

            Stream reader = new FileStream(filePath,FileMode.Open);

            Customer customer = (Customer)serializer.Deserialize(reader);
            
            reader.Close();
           Console.WriteLine($"Customer Name: {customer.Name} Address Count:{customer.Addresses.Count}");
        }
    }
}
