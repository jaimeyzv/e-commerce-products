using E.C.Products.Domain.Entities;
using E.C.Products.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace E.C.Products.Persistence.Shared
{
    public class ECProductsDbContext : DbContext
    {
        public ECProductsDbContext(DbContextOptions<ECProductsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
    }
}
