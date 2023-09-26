using Microsoft.AspNetCore.Mvc;
using RestFulAPI.Models;
using RestFulAPI.Repositories;

namespace RestFulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("all the shirts");
        }

        [HttpGet("{id}")]
        public IActionResult GetShirtsById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var shirt = ShirtRepository.GetShirtById(id);

            if (shirt == null)
            {
                return NotFound();
            }
            return Ok(shirt);
        }

        [HttpPost]
        public IActionResult CreateShirts([FromForm] Shirt shirt)
        {
            return Ok ("create shirt");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShirts(int id)
        {
            return Ok($"Update  shirts with ID : {id}");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteShirtsById(int id)
        {
            return Ok($"Delete  shirts with ID : {id}");
        }
    }
}
