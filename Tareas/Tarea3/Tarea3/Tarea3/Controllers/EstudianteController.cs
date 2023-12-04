using Microsoft.AspNetCore.Mvc;
using Tarea3.Data;

namespace Tarea3.Controllers {
  public class EstudianteController : Controller {
    
    private readonly EstudianteContext _context;

    public EstudianteController(EstudianteContext context) {
      _context = context;
    }

    //Todas los estudiantes
    public IActionResult Lista() {
      var estudiantes = _context.Estudiantes.ToList();
      return View(estudiantes);
    }

    //Estudiante por ID
    public IActionResult Detalles(int? id) {

      if(id == null) {
        return NotFound();
      }

      var estudiante = _context.Estudiantes.FirstOrDefault(manager => manager.Id == id);

      if(estudiante == null) {
        return NotFound();
      }

      return View(estudiante);
    }
  
  }
}
