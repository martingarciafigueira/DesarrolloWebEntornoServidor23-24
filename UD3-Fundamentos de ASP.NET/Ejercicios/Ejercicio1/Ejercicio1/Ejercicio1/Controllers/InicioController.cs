using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
	public class InicioController : Controller
	{
		// GET: Inicio/Bienvenida/nombreDeUsuario
		[HttpGet]
		public ActionResult Bienvenida(string nombreDeUsuario)
		{
			ViewBag.NombreDeUsuario = nombreDeUsuario;
			return View();
		}
	}
}
