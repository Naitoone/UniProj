namespace UniProj.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdWorker { get; set; }
        public int IdAddress { get; set; }
        public int IdClient { get; set; }
        public string OrderDate { get; set; }   
        public string OrderStatus { get; set; }

        public Client Client { get; set; }
        public Address Address { get; set; }
        public Worker Worker { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
