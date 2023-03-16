using Fruit.Model;

namespace Fruit.Repository.Interface 
{
    public interface IFruitRepository
    {
        Task<List<FruitModel>> ListAllFruits();
        Task<FruitModel> ListFruitById(int id);
        Task<FruitModel> CreateNewFruit(FruitModel fruit);
    }
}