using Microsoft.EntityFrameworkCore;
using Fruit.Model;

namespace Fruit.Data 
{
    public class FruitDbContext : DbContext 
    {
        public FruitDbContext(DbContextOptions<FruitDbContext> options)
        : base(options)
        {
        }
        public DbSet<FruitModel> Fruit { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}