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
		[Route("/Products/Details/{id}")]
		public IActionResult Details(string id)
		{
			// Aquí puedes utilizar el ID para buscar los detalles del producto en la base de datos o en alguna otra fuente de datos

			// Por ahora, simplemente pasaremos el ID a la vista para mostrarlo
			ViewBag.ProductId = id;

			return View();
		}

	}
}
