using APBD_06_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD_06_WebApi.Controllers
{
    // api/tests => [controller] = Tests
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        
        // GET api/tests
        [HttpGet]
        public IActionResult Get()
        {
            var animals = Database.Animals;
            return Ok(animals);
        }
        
        // GET api/tests/{id}          
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
            return Ok(animal);
        }

        // POST api/tests { "id": 4, "name": "Test4" }
        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }
    }
}
