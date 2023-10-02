using Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio2.Controllers
{
	public class CountryController : Controller
	{
		// GET: Country
		public ActionResult Index()
		{
			var countries = new List<string> { "Argentina", "Brazil", "Canada", "Denmark", "Egypt", "France" };
			var viewModel = new CountryViewModel { Countries = countries };
			return View(viewModel);
		}
	}
}
