using Microsoft.AspNetCore.Mvc;

namespace Ejercicio8.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(string username)
		{
			HttpContext.Session.SetString("Username", username);
			return RedirectToAction("Profile");
		}

		public IActionResult Profile()
		{
			string username = HttpContext.Session.GetString("Username");
			ViewBag.Username = username;
			return View();
		}
	}

}
