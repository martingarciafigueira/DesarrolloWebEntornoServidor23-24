using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/Pedido/CrearPedido")]
        public IActionResult CrearPedido(Pedido pedido)
        {
            return View("MostrarPedido", pedido);
        }

        [HttpGet]
        [Route("/Pedido/CrearPedido")]
        public IActionResult CrearPedido()
        {
            return View();
        }
    }
}
