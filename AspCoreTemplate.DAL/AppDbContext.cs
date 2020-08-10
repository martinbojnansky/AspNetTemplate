using AspCoreTemplate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspCoreTemplate.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Here we can singularize table names if needed.
            // modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
