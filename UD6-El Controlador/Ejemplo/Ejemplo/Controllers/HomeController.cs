using Ejemplo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejemplo.Controllers
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

        [Route("product/{productId}/{productTitle}", Name = "CategoryProduct")]
        public ActionResult Show(int productId, string productTitle)
        {
            return View();
        }

        [Route("product/edit/{id:int}")]
        public ActionResult GetProductById(int id)
        {
            return View();
        }

        [Route("user/confirm/{pin:alpha:length(4}")]
        public ActionResult Confirm(string pin)
        {
            return View();
        }

        [Route("test/{data:alpha:length(3)=car}")]
        public ActionResult Test(string data)
        {
            return View();
        }

    }
}