using Microsoft.AspNetCore.Mvc;
using ProyectoPokemon.Models;

namespace ProyectoPokemon.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonContext _contexto;

        public PokemonController(PokemonContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var manager = new PokemonManager(_contexto);
            var pokemons = manager.GetAllPokemons();
            return View("Index", pokemons);
        }
        [HttpGet]
        //Para pasar atributos en esta URL, se debe especificar de esta forma. Por ejemplo:
        //Pokemon/GetPokemons/?Peso=7&Altura=13
        public IActionResult Info(int idPokemon)
        {
            var manager = new PokemonManager(_contexto);
            var pokemon = manager.GetPokemonByID(idPokemon);
            return View("Info", pokemon);
        }

        //Para pasar atributos en esta URL, se debe especificar de esta forma. Por ejemplo:
        //Pokemon/Info?IdPokemon=15
        public IActionResult GetPokemons(float peso, float altura)
        {
            var manager = new PokemonManager(_contexto);
            var pokemon = manager.GetPokemonByPesoAltura(peso, altura);
            return View("ListaPokemon", pokemon);
        }
    }
}
