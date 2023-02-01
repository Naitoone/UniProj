namespace UniProj.Models
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public int IdProduct { get; set; }

        public Product Product { get; set; }
        public Category Category { get; set; }

    }
}
