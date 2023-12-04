using Microsoft.AspNetCore.Mvc;
using Tarea3.Data;
using Tarea3.Models;

namespace Tarea3.Controllers {
  public class LoginController : Controller {

    private readonly LoginContext _context;

    public LoginController(LoginContext context) {
      _context = context;
    }

    public IActionResult Logueate() {
      return View();
    }

    [HttpPost]
    public IActionResult Logueate(IFormCollection collection) {
      var logins = _context.Logins.ToList();

      ViewBag.username = Request.Form["username"];

      var manager = new LoginManager(_context);

      if(!manager.CheckCredentials(Request.Form["username"], Request.Form["password"])) {
        ViewBag.message = "Las credenciales no son válidas";
        return View();
      }

      return RedirectToAction("Index", "Home");
    }

    public IActionResult MiCurriculum() {
      return View();
    }

  }
}
