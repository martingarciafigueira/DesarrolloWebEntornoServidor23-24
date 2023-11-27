using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    [RoutePrefix("calculator")]
    public class CalculatorController : Controller
    {
        [Route("sum/{a}/{b?}")]
        public ActionResult Sum(int a, int? b) { ... }

        [Route("product/{a}/{b=1}")]
        public ActionResult Product(int a, int b) { ... }

    }
}
