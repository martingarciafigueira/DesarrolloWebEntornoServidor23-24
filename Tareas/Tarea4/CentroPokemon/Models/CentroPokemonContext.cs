using Microsoft.EntityFrameworkCore;
using CentroPokemon.Models;
using System.Linq;

namespace CentroPokemon.Data
{
    public class CentroPokemonContext : DbContext
    {
        public CentroPokemonContext(DbContextOptions<CentroPokemonContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> pokemon { get; set; }
        public DbSet<Tipo> tipo { get; set; }
        public DbSet<PokemonTipo> pokemon_tipo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().HasKey(p => p.PokemonId);
            modelBuilder.Entity<Tipo>().HasKey(t => t.id_tipo);
            modelBuilder.Entity<PokemonTipo>().HasKey(pt => new { pt.PokemonId, pt.id_tipo });
        }
    }
}
