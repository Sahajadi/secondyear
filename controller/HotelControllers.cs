using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using secondyear.Context;
using secondyear.Modal;


namespace secondyear.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
                var hotels = _context.hotel.ToList(); // Ensure 'Hotels' is the correct DbSet property
                return Ok(hotels);
        }
        
        [HttpPost]

        public IActionResult Create ([FromBody] Hotels hotel)
        {
            _context.hotel.Add(hotel);
            _context.SaveChanges();
            return Ok("Created Sucessfully");
        }
      

    }
}

