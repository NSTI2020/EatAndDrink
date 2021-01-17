using System.Threading.Tasks;
using EatAndDrink.Domain.Entities;
using EatAndDrink.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.WebApi.Controllers
{

    [ApiController]
    [Route("api/{controller}")]
    public class Products : ControllerBase
    {
        private readonly EatDrinkRepository _repo;
        public Products(EatDrinkRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            Product[] result = await _repo.GetAllProducts();

            return Ok(result);


        }






    }
}
