using Ejercicio3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3.Controllers
{
    public class FutbolistaController : Controller
    {
        // GET: FutbolistaController
        public ActionResult Index()
        {
            List<Futbolista> futbolistas = new List<Futbolista>
            {   new Futbolista("Thibaut","Courtois",29),
                new Futbolista("Karim","Benzema",36),
                new Futbolista("Vinicius","Junior",22),
                new Futbolista("Rodrygo","Goes",21)};

            return View(futbolistas);
        }
    }
}
