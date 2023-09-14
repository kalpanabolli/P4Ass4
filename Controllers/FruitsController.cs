using Assessment4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assessment4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        static List<Fruit> Fruits = new List<Fruit>
        {

            new Fruit(){Id=1,FName="Apple"}
        };
        [HttpGet]
        public ActionResult<IEnumerable<Fruit>> Get()
        {
            return Fruits;
        }
        [HttpGet("{id}")]
        public ActionResult<Fruit> Get(int id)
        {
            var Fruit = Fruits.Find(t => t.Id == id);
            if (Fruit == null)
            {
                return NotFound();
            }
            return Fruit;
        }
        [HttpPost]
        public void Post([FromBody] Fruit Fruit)
        {
            Fruit.Id = Fruits.Count + 1;
            Fruits.Add(Fruit);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Fruit updatedFruit)
        {
            var Fruit = Fruits.Find(t => t.Id == id);
            if (Fruit == null)
            {
                return NotFound();
            }

            Fruit.FName = updatedFruit.FName;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Fruit = Fruits.Find(m => m.Id == id);
            if (Fruit == null)
            {
                return NotFound();
            }

            Fruits.Remove(Fruit);
            return NoContent();
        }
    }
}
