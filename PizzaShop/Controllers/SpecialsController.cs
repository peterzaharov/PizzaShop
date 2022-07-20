using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Model;

namespace PizzaShop.Controllers
{
    [Route("specials")]
    [ApiController]
    public class SpecialsController : Controller
    {
        private readonly PizzaShopContext _db;

        public SpecialsController(PizzaShopContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetPizzas()
        {
            return (await _db.Specials!.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }
    }
}