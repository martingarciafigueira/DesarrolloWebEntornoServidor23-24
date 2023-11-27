using EjemploSesion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace EjemploSesion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Crear una lista de ejemplo
            List<string> lista = new List<string> { "Hola", "Mundo", "Serialización" };

            // Serializar la lista a un array de bytes
            byte[] bytes = SerializeList(lista);

            //Metemos la lista en la variable de sesión

            byte[] arrayBytes = SerializeList(lista);

            HttpContext.Session.Set("LISTA", arrayBytes);

            arrayBytes = HttpContext.Session.Get("LISTA");

            return View();
        }

        public IActionResult MuestraNumeros()
        {
            List<string> lista = DeserializeBytes(HttpContext.Session.Get("LISTA"));
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}