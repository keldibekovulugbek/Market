using Market.Domain.Entities.Products;
using Market.Domain.Entities.Suppliers;
using Microsoft.EntityFrameworkCore;

namespace Market.Data.DBContexts
{
    public class MarketDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "Host=localhost;Port=5432;Database=market2;Username=postgres;Password=12042003";
            optionsBuilder.UseNpgsql(connectionString);


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Product>().HasOne(p => p.Supplier).WithMany(s => s.Products).HasForeignKey(p => p.SupplierId);
        }

    }
}
