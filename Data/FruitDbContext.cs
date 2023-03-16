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
        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<FruitModel>()
        .HasData(
            new FruitModel 
            {
                Id = 1,
                Description = "Banana",
                ValueOne = 10,
                ValueTwo = 2
            },
            new FruitModel 
            {
                Id = 2,
                Description = "Maça",
                ValueOne = 0,
                ValueTwo = 5
            }
        );
    }
}