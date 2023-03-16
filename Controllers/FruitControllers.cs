using Microsoft.AspNetCore.Mvc;
using Fruit.Model;

namespace Fruit.Controllers {
    
    [Route("api/[Controller]")]
    [ApiController]

    public class FruitController : ControllerBase {

        [HttpGet]
        public ActionResult<List<FruitModel>> GetFruits() {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<FruitModel> GetFruitById() {
            return Ok();
        }

        [HttpPost]
        public ActionResult<FruitModel> PostFruit() {
            return Ok();
        }
    }
}
