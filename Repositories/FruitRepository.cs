using Microsoft.EntityFrameworkCore;
using Fruit.Repository.Interface;
using Fruit.Model;
using Fruit.Data;

namespace Fruit.Repository
{
    public class FruitRepository : IFruitRepository
    {
        private readonly FruitDbContext _dbContext;

        public FruitRepository(FruitDbContext fruitDbContext)
        {
            _dbContext = fruitDbContext;
        }
        public async Task<List<FruitModel>> ListAllFruits()
        {
            return await _dbContext.Fruit.ToListAsync();
        }
        public async Task<FruitModel> ListFruitById(int id)
        {
            return await _dbContext.Fruit.FirstOrDefaultAsync(fruit => fruit.Id == id);
        }
        public async Task<FruitModel> CreateNewFruit(FruitModel fruit)
        {
            await _dbContext.Fruit.AddAsync(fruit);
            await _dbContext.SaveChangesAsync();

            return fruit;
        }
    }
}