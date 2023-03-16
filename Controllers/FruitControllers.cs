using Microsoft.AspNetCore.Mvc;
using Fruit.Model;
using Fruit.Repository.Interface;

namespace Fruit.Controllers {
    
    [Route("api/[Controller]")]
    [ApiController]

    public class FruitController : ControllerBase {
        private readonly IFruitRepository _fruitsRepository;
        public FruitController(IFruitRepository fruitsRepository)
        {
            _fruitsRepository = fruitsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<FruitModel>>> GetFruits() {
            List<FruitModel> fruits = await _fruitsRepository.ListAllFruits();
            return Ok(fruits);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FruitModel>> GetFruitById(int id) {
            FruitModel fruit = await _fruitsRepository.ListFruitById(id);
            return Ok(fruit);
        }

        [HttpPost]
        public async Task<ActionResult<FruitModel>> PostFruit([FromBody]FruitModel fruit) {
            FruitModel createdFruit = await _fruitsRepository.CreateNewFruit(fruit);
            return Ok(createdFruit);
        }
    }
}
