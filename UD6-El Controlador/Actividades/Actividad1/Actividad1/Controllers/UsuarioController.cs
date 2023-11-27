using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return Content("Nos manda al Index");
        }
        public IActionResult Registro()
        {
            return Content("Nos permite registrarnos");
        }
        public IActionResult InicioSesion()
        {
            return Content("Nos permite iniciar sesión");
        }
        [Route("perfil/{nombreUsuario:length(3,20)}")]
        public IActionResult Perfil(string nombreUsuario)
        {
            return Content("Nos permite acceder al perfil de " + nombreUsuario);
        }
    }
}
