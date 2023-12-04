using Microsoft.AspNetCore.Mvc;
using Tarea3.Data;

namespace Tarea3.Controllers
{

    public class AsignaturaController : Controller {

    private readonly AsignaturaContext _context;

    public AsignaturaController(AsignaturaContext context) {
      _context = context;
    }

    //Todas las asignaturas
    public IActionResult Lista() {
      var asignaturas = _context.Asignaturas.ToList();
      return View(asignaturas);
    }

    //Asignatura por ID
    public IActionResult Detalles(int? id) {

      if(id == null) {
        return NotFound();
      }

      var asignatura = _context.Asignaturas.FirstOrDefault(manager => manager.Id == id);

      if(asignatura == null) {
        return NotFound();
      }

      return View(asignatura);
    }
  }
}
