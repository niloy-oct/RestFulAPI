using Microsoft.AspNetCore.Mvc;
using RestFulAPI.Models;

namespace RestFulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "all the shirts";
        }

        [HttpGet("{id}")]
        public string GetShirtsById(int id)
        {
            return $"Reading  shirts with ID : {id}";
        }

        [HttpPost]
        public string CreateShirts([FromForm] Shirt shirt)
        {
            return "create shirt";
        }

        [HttpPut("{id}")]       
        public string UpdateShirts(int id)
        {
            return $"Update  shirts with ID : {id}";
        }


        [HttpDelete("{id}")]       
        public string DeleteShirtsById(int id)
        {
            return $"Delete  shirts with ID : {id}";
        }
    }
}
