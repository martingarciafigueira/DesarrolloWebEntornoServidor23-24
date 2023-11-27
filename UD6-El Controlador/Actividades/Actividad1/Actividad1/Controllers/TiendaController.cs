using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class TiendaController : Controller
    {
        [Route("Tienda/{id:int:min(0)}")]
        public IActionResult Index(int id)
        {
            return Content("Nos manda al Index con el id: " + id);
        }
        public IActionResult Listar()
        {
            return Content("Nos muestra una lista de productos de la tienda");
        }
        public IActionResult Detalle()
        {
            return Content("Nos muestra el detalle de un producto");
        }
        public IActionResult AgregarAlCarrito()
        {
            return Content("Nos permite agregar al carrito");
        }
        public IActionResult RealizarPedido()
        {
            return Content("Nos permite realizar un pedido");
        }
    }
}
