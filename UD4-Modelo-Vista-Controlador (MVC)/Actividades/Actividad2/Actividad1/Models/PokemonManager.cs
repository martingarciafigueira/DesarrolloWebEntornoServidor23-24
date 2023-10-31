using Actividad1.Models;
using System.Xml.Linq;

namespace Actividad2.Models
{
    public class PokemonManager : IDisposable
    {
        private readonly PokemonContext _context;

        public PokemonManager(PokemonContext context)
        {
            _context = context;
        }

        public IEnumerable<Pokemon> GetAllPokemon()
        {
            var pokemons = from pokemon in _context.Pokemons
                   select pokemon;
            return pokemons;
        }

        public Pokemon GetPokemonByID(int id)
        {
            return (Pokemon)_context.Pokemons.FirstOrDefault(pokemon => pokemon.PokemonId == id);
        }

        public IEnumerable<Pokemon> GetPokemonByPesoAltura(float peso, float altura)
        {
            var pokemons = from p in _context.Pokemons
                          where p.altura == altura && p.peso == peso
                          select p;
            return pokemons.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
