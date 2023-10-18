namespace ProyectoPokemon.Models
{
    public class PokemonManager : IDisposable
    {
        private readonly PokemonContext _data;

        public PokemonManager(PokemonContext data)
        {
            _data = data;
        }

        //Implementamos los métodos
        public IEnumerable<Pokemon> GetAllPokemons()
        {
            var pokemons = from pokemon in _data.Pokemon
                           select pokemon;
            return pokemons;
        }
        public Pokemon GetPokemonByID(int idPokemon)
        {
            return _data.Pokemon.FirstOrDefault(pokemon => pokemon.PokemonId == idPokemon);
        }
        public IEnumerable<Pokemon> GetPokemonByPesoAltura(float peso, float altura)
        {
            var pokemons = from pokemon in _data.Pokemon
                           where pokemon.peso == peso && pokemon.altura == altura
                           select pokemon;
            return pokemons;
        }

        public void Dispose()
        {
            _data.Dispose();
        }
    }
}
