using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Agregar()
        {
            return View();
        }
        public IActionResult VerPokemon(int numero_pokedex, string nombre, float peso, float altura)
        {
            Pokemon pkmn = new Pokemon();
            pkmn.numero_pokedex = numero_pokedex;
            pkmn.nombre = nombre;
            pkmn.peso = peso;
            pkmn.altura = altura;

            return View(pkmn);
        }
    }
}
