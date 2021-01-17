using EatAndDrink.Repository.Data;
using Microsoft.AspNetCore.Mvc;
namespace EatAndDrink.WebApi.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class SeedController : ControllerBase
    {
        private readonly SeedingServices _seeding;
        public SeedController(SeedingServices seeding)
        {
            _seeding = seeding;
        }

        [HttpGet]
        public IActionResult get()
        {
            string[] msgs = new string[] { "DataBase was seeded!", "Seed DataBase fail" };

            if (_seeding.Seed())
            {
                return Ok(msgs[0]);
            }
            else
            {
                return Ok(msgs[1]);

            }
        }


    }
}
