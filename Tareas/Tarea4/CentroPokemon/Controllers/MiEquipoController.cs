using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using CentroPokemon.Models;
using CentroPokemon.Repository;
using System.Diagnostics;

namespace CentroPokemon.Controllers
{
    public class MiEquipoController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private readonly CentroPokemonRepository _repository;

        public MiEquipoController(IHttpContextAccessor httpContextAccessor, CentroPokemonRepository repository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Pokemon> miEquipo = DeserializarMiEquipo();

            if (miEquipo == null || miEquipo.Count == 0)
            {
                return View(new List<Pokemon>());
            }

            return View(miEquipo);
        }

        [HttpPost]
        public IActionResult AgregarPokemon(int pokemonId)
        {
            List<Pokemon> miEquipo = DeserializarMiEquipo();

            if (miEquipo == null)
            {
                miEquipo = new List<Pokemon>();
            }

            if (miEquipo.Count >= 6)
            {
                TempData["Mensaje"] = "¡Lástima, tu equipo ya está completo!";
            }
            else
            {
                Pokemon pokemon = _repository.GetPokemonById(pokemonId);

                if (pokemon != null)
                {
                    miEquipo.Add(pokemon);
                    SerializarMiEquipo(miEquipo);
                }
            }

            return RedirectToAction("Index");
        }


        private List<Pokemon> DeserializarMiEquipo()
        {
            byte[] bytes = _session.Get("MiEquipo");

            if (bytes != null)
            {
                string jsonString = Encoding.UTF8.GetString(bytes);
                return JsonSerializer.Deserialize<List<Pokemon>>(jsonString);
            }

            return null;
        }

        private void SerializarMiEquipo(List<Pokemon> miEquipo)
        {
            string jsonString = JsonSerializer.Serialize(miEquipo);
            byte[] bytes = Encoding.UTF8.GetBytes(jsonString);
            _session.Set("MiEquipo", bytes);
        }
    }
}
