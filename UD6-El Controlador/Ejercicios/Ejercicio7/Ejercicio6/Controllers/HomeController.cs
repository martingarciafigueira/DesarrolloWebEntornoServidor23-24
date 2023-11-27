using Ejercicio6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio6.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		[HttpPost]
		public IActionResult Contact(ContactForm contactForm)
		{
			if (!ModelState.IsValid)
			{
				return View(contactForm);
			}

			// Guarda los datos en la base de datos o realiza alguna otra operación

			// Muestra un mensaje de confirmación al usuario en una vista
			ViewBag.Message = "¡Gracias por contactarnos! Te responderemos pronto.";

			return View();
		}

		[HttpGet]
		[Route("/Home/Contact")]
		public IActionResult Contact()
		{
			return View("ContactForm");
		}

	}
}