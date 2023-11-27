using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[Route("/Products/List")]
		public IActionResult List()
		{
			return View();
		}
	}
}
