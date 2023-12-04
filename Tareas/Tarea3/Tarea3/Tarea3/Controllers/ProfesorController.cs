using Microsoft.AspNetCore.Mvc;
using Tarea3.Data;

namespace Tarea3.Controllers {
  public class ProfesorController : Controller {

    private readonly ProfesorContext _context;

    public ProfesorController(ProfesorContext context) {
      _context = context;
    }

    //Todas los profesores
    public IActionResult Lista() {
      var profesores = _context.Profesores.ToList();
      return View(profesores);
    }

    //Profesor por ID
    public IActionResult Detalles(int? id) {

      if(id == null) {
        return NotFound();
      }

      var profesores = _context.Profesores.FirstOrDefault(manager => manager.Id == id);

      if(profesores == null) {
        return NotFound();
      }

      return View(profesores);
    }

  }
}
