using Microsoft.AspNetCore.Mvc;
using RestFulAPI.Filter;
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
            return Ok(ShirtRepository.GetShirts());
        }

        [HttpGet("{id}")]
        [ShirtIDValidate]
        public IActionResult GetShirtsById(int id)
        {

            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        public IActionResult CreateShirts([FromBody] Shirt shirt)
        {
            if (shirt == null)
            {
                return BadRequest();
            }
            var existingShirt = ShirtRepository.GetShirtByProperties(shirt.Name, shirt.Color, shirt.Gender, shirt.Size);
            if (existingShirt != null)
            {
                return Ok("create shirt");
            }
            ShirtRepository.AddShirt(shirt);
            return CreatedAtAction(nameof(GetShirtsById), new { id = shirt.ShirtId }, shirt);

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
