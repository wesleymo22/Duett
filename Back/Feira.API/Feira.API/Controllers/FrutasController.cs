using Feira.API.Models;
using Feira.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feira.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrutasController : ControllerBase
    {
        private IFrutasService _frutasService;

        public FrutasController(IFrutasService frutasService)
        {
            _frutasService = frutasService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Frutas>>> GetFrutas()
        {
            try
            {
                var frutas = await _frutasService.GetFrutas();
                return Ok(frutas);
            }
            catch
            {
                return BadRequest("Request invalido");
            }
        }

        [HttpGet("{id:int}", Name ="Getfruta")]
        public async Task<ActionResult<Frutas>> GetFruta(int id)
        {
            try
            {
                var fruta = await _frutasService.GetFrutas(id);

                if (fruta == null)
                    return NotFound($"Não existe aluno com id= {id}");

                return Ok(fruta);
            }
            catch
            {
                return BadRequest("Request invalido");
            }
        }
    }
}
