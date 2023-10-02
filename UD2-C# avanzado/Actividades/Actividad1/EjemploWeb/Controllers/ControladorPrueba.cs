using Microsoft.AspNetCore.Mvc;

namespace ConsolaWeb.Controllers
{
	public class ControladorPrueba : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public static string Metodo1()
		{
			return "Metodo de prueba";
		}
	}
}
