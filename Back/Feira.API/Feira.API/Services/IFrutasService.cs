using Feira.API.Context;
using Feira.API.Models;

namespace Feira.API.Services
{
    public interface IFrutasService
    {
        Task<IEnumerable<Frutas>> GetFrutas();
        Task<Frutas> GetFrutas(int id);
    }
}
