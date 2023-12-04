using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class TiendaController : Controller
    {
        [Route("Tienda/Index/{id:int}")]
        public IActionResult Index(int id)
        {
            return Content("El ID es: " + id);
        }
    }
}
