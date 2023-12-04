using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class PedidoController : Controller
    {
        [Route("Pedido/CrearPedido")]
        public IActionResult CrearPedido([Bind("Cliente,Direccion,Ciudad")] Pedido pedido)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
