using Feira.API.Context;
using Feira.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feira.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeiraController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FeiraController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IEnumerable<Frutas> Get()
        {
            return _context.Frutas;
        }

    }
}
