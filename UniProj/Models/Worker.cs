using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniProj.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public int IdPosition { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }

        public Position Position { get; set; }

        public ICollection<Order> Orders { get;set; }
    }
}
