using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniProj.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public decimal Price { get; set; }

        public ICollection<CategoryProduct> CategoryProducts { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        

    }
}
