namespace UniProj.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string StreetNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
