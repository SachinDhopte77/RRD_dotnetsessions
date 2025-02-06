namespace XMLCommonLib
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Address> Addresses { get;   set; }

        public Customer() { 
          Addresses = new List<Address> { };
        }


        

    }
}
