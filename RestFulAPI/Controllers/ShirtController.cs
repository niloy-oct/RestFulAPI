using Microsoft.AspNetCore.Mvc;

namespace RestFulAPI.Controllers
{
    [ApiController]
    public class ShirtController : ControllerBase
    {
        [HttpGet]
        [Route("/shirts")]
        public string GetShirts()
        {
            return "all the shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirtsById(int id)
        {
            return $"Reading  shirts with ID : {id}";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdateShirts(int id)
        {
            return $"Update  shirts with ID : {id}";
        }


        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeleteShirtsById(int id)
        {
            return $"Delete  shirts with ID : {id}";
        }
    }
}
