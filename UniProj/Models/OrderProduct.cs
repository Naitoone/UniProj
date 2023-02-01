namespace UniProj.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
