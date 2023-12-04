using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("Blog/Listar")]
        public IActionResult Listar()
        {
            return Content("Listamos las publicaciones del blog");
        }
        public IActionResult Detalle(int idPublicacion)
        {
            return Content("Muestra los detalles de una publicación");
        }
        public IActionResult Crear(string nombre)
        {
            return Content("Crear una nueva publicación");
        }
        public IActionResult Editar(string nombre)
        {
            return Content("Modificar una publicación");
        }
        public IActionResult Eliminar(string nombre)
        {
            return Content("Borrar una publicación");
        }
    }
}
