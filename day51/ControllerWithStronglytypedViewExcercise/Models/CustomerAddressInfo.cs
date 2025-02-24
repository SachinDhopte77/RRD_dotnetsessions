namespace ControllerWithStronglytypedViewExcercise.Models
{
    public class CustomerAddressInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<CutomerAddress> Addresses { get; set; }
    }
}
