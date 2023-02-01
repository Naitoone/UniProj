using Microsoft.EntityFrameworkCore;
using UniProj.Models;

namespace UniProj.Data
{
    public class WebShopContext : DbContext
    {
        public WebShopContext(DbContextOptions<WebShopContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public object Client { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<CategoryProduct>().ToTable("CategoryProduct");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderProduct>().ToTable("OrderProduct");
            modelBuilder.Entity<Position>().ToTable("Position");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Worker>().ToTable("Worker");

            modelBuilder.Entity<Worker>()
                .HasOne(x => x.Position)
                .WithMany(x => x.Workers)
                .HasForeignKey(x => x.IdPosition);
        }
    }
}