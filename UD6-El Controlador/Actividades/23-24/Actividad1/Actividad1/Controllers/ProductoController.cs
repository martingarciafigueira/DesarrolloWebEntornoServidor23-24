using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listar()
        {
            return Content("Listamos los productos");
        }
        public IActionResult Detalle(int idProducto)
        {
            return Content("Detallamos un producto específico");
        }
        [Route("Producto/Detalles/{id:int:length(4)}-{slug:alpha}")]
        public IActionResult Detalles(int id, string slug)
        {
            return Content("El ID es: " + id + " y el slug es: " + slug);
        }
        [Route("Listado/{categoria?}/{marca?}")]
        public IActionResult Listado(string categoria, string marca)
        {
            GetNombre();
            return Content($"Listamos los productos de {categoria} y {marca}");
        }
        [NonAction]
        public string GetNombre()
        {
            return "Martín";
        }
        [Route("Producto/Buscar/{terminoBusqueda}")]
        public IActionResult Buscar(string terminoBusqueda)
        {
            if (terminoBusqueda == null || terminoBusqueda == "")
            {
                RedirectToAction("Index");
            }
            return Content($"Se busca por el término {terminoBusqueda}");
        }
        [Route("Producto/Agregar/{producto}")]
        public IActionResult Agregar(Producto producto)
        {
            if (producto == null)
            {
                return View("FormularioAgregar");
            }
            //Llamamos al modelo para agregarlo a la BD
            RedirectToAction("Index");
            return Content($"Redirige a la accion Index");
        }
        [Route("Producto/Editar/{id}/{producto}")]
        public IActionResult Editar(int id, Producto producto)
        {
            if (id == null) RedirectToAction("Index");
            if (producto == null) return View("FormularioAgregar");
            else
            {
                //actualizar producto
                RedirectToAction("Index");
            }
            return Content("Editamos");
        }

        public IActionResult Eliminar(string nombre)
        {
            return Content("Buscamos productos por nombre");
        }

    }

    public class Producto
    {
    }
}
