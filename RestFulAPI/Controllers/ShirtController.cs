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
            return Ok("all the shirts");
        }

        [HttpGet("{id}")]
        [ShirtIDValidate]
        public IActionResult GetShirtsById(int id)
        {
           
            return Ok(ShirtRepository.GetShirtById(id));
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
