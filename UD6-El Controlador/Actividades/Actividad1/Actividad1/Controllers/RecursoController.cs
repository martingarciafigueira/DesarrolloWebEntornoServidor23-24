using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class RecursoController : Controller
    {
        public IActionResult Index()
        {
            return Content("Nos manda al Index");
        }
        public IActionResult Listar()
        {
            return Content("Nos muestra una lista de recursos");
        }
        public IActionResult Detalle()
        {
            return Content("Nos muestra el detalle de un recurso");
        }
        public IActionResult Descargar()
        {
            return Content("Nos permite descargar un recurso");
        }
    }
}
