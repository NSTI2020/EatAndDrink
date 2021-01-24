using System.Threading.Tasks;
using EatAndDrink.Domain.Entities;
using EatAndDrink.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Products : ControllerBase
    {
        private readonly EatDrinkRepository _repo;
        public Products(EatDrinkRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                Product[] result = await _repo.GetAllProducts();

                if (result != null)
                {
                    return Ok(result);
                }
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro: {ex.Message}");
            }

            return BadRequest();
        }

    }
}
