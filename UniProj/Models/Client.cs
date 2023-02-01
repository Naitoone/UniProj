namespace UniProj.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; } 

        public string Email { get; set; }

        public string NrPhone { get; set;}

        public ICollection<Order> Orders { get; set; }
    }
}
