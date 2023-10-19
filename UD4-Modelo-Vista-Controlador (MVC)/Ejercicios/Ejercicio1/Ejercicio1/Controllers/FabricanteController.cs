using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Ejercicio1.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly FabricanteContext _contexto;

        public FabricanteController(FabricanteContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            List<Fabricante> listaFabricantes = new List<Fabricante>();

            var fabricantes = from fabricante in _contexto.Fabricante
                              select fabricante;
            listaFabricantes = fabricantes.AsEnumerable().ToList();

            return View("Index", listaFabricantes);
        }
    }
}
