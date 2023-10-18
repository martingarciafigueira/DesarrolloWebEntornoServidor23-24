using Microsoft.EntityFrameworkCore;

namespace ProyectoPokemon.Models
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) { }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
