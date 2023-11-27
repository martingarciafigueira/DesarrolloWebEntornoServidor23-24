using Ejercicio5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio5.Controllers
{
	public class OrdersController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult OrderDetails(Order order)
		{
			return View(order);
		}
		public IActionResult CreateOrder()
		{
			return View();
		}

	}
}
