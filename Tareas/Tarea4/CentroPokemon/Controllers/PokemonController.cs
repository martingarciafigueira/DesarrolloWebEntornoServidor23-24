using Microsoft.AspNetCore.Mvc;
using CentroPokemon.Models;
using Microsoft.Extensions.Configuration;
using CentroPokemon.Repository;
using System.Collections.Generic;

namespace CentroPokemon.Controllers
{
    public class PokemonController : Controller
    {
        private readonly string _connectionString;

        public PokemonController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConexionTarea4");
        }

        public IActionResult Lista(string typeSelected, double? weightSelected, double? heightSelected)
        {
            var repository = new CentroPokemonRepository(_connectionString);
            var pokemons = repository.GetAllPokemons();
            var tipos = repository.GetAllTipos();

            IEnumerable<Pokemon> pokemon_list = null;

            if (!string.IsNullOrWhiteSpace(typeSelected))
            {
                pokemon_list = repository.GetPokemonByTipo(typeSelected);
            }
            else if (weightSelected.HasValue)
            {
                pokemon_list = repository.GetPokemonByPeso(weightSelected.Value);
            }
            else if (heightSelected.HasValue)
            {
                pokemon_list = repository.GetPokemonByAltura(heightSelected.Value);
            }

            ViewBag.PokemonList = pokemons;
            ViewBag.TipoList = tipos;
            ViewBag.PokemonFilteredList = pokemon_list ?? pokemons;
            ViewBag.SelectedWeight = weightSelected;
            ViewBag.SelectedHeight = heightSelected;

            return View();
        }
        public IActionResult Detalle(int id)
        {
            var repository = new CentroPokemonRepository(_connectionString);
            var pokemon = repository.GetPokemonById(id);

            if (pokemon == null)
            {
                return NotFound();
            }

            var evoluciones = repository.GetEvolutions(id);
            var involuciones = repository.GetInvolutions(id);
            var movimientos = repository.GetMovimientosByPokemonId(id);

            var viewModel = new DetallePokemonViewModel
            {
                Pokemon = pokemon,
                Evoluciones = evoluciones,
                Involuciones = involuciones,
                Movimientos = movimientos
            };

            return View("DetallePokemon", viewModel);
        }
        public IActionResult GenerarEquipo()
        {
            List<Pokemon> equipoAleatorio = GenerarEquipoAleatorio();

            return View(equipoAleatorio);
        }

        private List<Pokemon> GenerarEquipoAleatorio()
        {
            var repository = new CentroPokemonRepository(_connectionString);
            List<Pokemon> todosLosPokemon = repository.GetAllPokemons().ToList();

            if (todosLosPokemon.Count < 6)
            {
                throw new Exception("Número inferior a 6");
            }

            List<Pokemon> equipoAleatorio = new List<Pokemon>();

            Random random = new Random();

            while (equipoAleatorio.Count < 6)
            {
                int indiceAleatorio = random.Next(0, todosLosPokemon.Count);

                Pokemon pokemonAleatorio = todosLosPokemon[indiceAleatorio];

                if (!equipoAleatorio.Contains(pokemonAleatorio))
                {
                    equipoAleatorio.Add(pokemonAleatorio);
                }
            }

            return equipoAleatorio;
        }



    }
}
