using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return Content("Nos manda al Index");
        }
        public IActionResult Listar()
        {
            return Content("Nos muestra las publicaciones");
        }
        public IActionResult Detalle()
        {
            return Content("Nos muestra el detalle de un producto");
        }
        public IActionResult Crear()
        {
            return Content("Nos permite crear un artículo");
        }
        public IActionResult Editar()
        {
            return Content("Nos permite editar un artículo");
        }
        public IActionResult Eliminar()
        {
            return Content("Nos permite borrar un artículo");
        }
    }
}
