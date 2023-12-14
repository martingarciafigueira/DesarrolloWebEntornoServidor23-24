using Microsoft.AspNetCore.Mvc;
using CentroPokemon.Models;
using CentroPokemon.Repository;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text;

namespace CentroPokemon.Controllers
{
    public class CombateController : Controller
    {
        private readonly string _connectionString;
        private readonly CentroPokemonRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public CombateController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _connectionString = configuration.GetConnectionString("ConexionTarea4");
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View("Combate");
        }

        public IActionResult Combate()
        {
            List<Pokemon> equipoAleatorioA = GenerarEquipoAleatorioCombate();
            List<Pokemon> equipoAleatorioB = GenerarEquipoAleatorioCombate();
            List<Pokemon> equipoAleatorioC = GenerarEquipoAleatorioCombate();
            List<Pokemon> MiEquipo = DeserializarMiEquipo();

            while (equiposIguales(equipoAleatorioA, equipoAleatorioB) || equiposIguales(equipoAleatorioA, equipoAleatorioC) || equiposIguales(equipoAleatorioC, equipoAleatorioB))
            {
                equipoAleatorioA = GenerarEquipoAleatorioCombate();
                equipoAleatorioB = GenerarEquipoAleatorioCombate();
                equipoAleatorioB = GenerarEquipoAleatorioCombate();
            }

            ViewBag.EquipoAleatorioA = equipoAleatorioA;
            ViewBag.EquipoAleatorioB = equipoAleatorioB;
            ViewBag.EquipoAleatorioC = equipoAleatorioC;
            ViewBag.MiEquipo = MiEquipo;

            return View(equipoAleatorioA); 
        }

        private bool equiposIguales(List<Pokemon> equipo1, List<Pokemon> equipo2)
        {
            foreach (var pokemon in equipo1)
            {
                if (!equipo2.Contains(pokemon))
                {
                    return false;
                }
            }
            return true;
        }


        private List<Pokemon> GenerarEquipoAleatorioCombate()
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
    }
}
