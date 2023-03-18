using Feira.API.Context;
using Feira.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Feira.API.Services
{
    public class FrutasService : IFrutasService
    {
        private readonly AppDbContext _context;

        public FrutasService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Frutas>> GetFrutas()
        {
            try
            {
                return await _context.Frutas.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Frutas> GetFrutas(int id)
        {
            var frutas = await _context.Frutas.FindAsync(id);
            return frutas;
        }
    }
}
