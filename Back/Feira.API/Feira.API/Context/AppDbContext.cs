using Feira.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Feira.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Frutas> Frutas { get; set; }
    }
}
