using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			// Verificar las credenciales aquí
			if (username == "admin" && password == "password")
			{
				// Credenciales válidas, redirigir al usuario a la página de inicio
				return RedirectToAction("Index", "Home");
			}
			else
			{
				// Credenciales inválidas, mostrar mensaje de error o redirigir a página de error
				ViewBag.ErrorMessage = "Credenciales inválidas. Inténtalo de nuevo.";
				return View();
			}
		}
	}
}
