using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Ejercicio1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoContext _contexto;

        public ProductoController(ProductoContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerProducto(int codigo)
        {
            List<Producto> listaProductos = new List<Producto>();

            listaProductos.Add(_contexto.Producto.FirstOrDefault(producto => producto.codigo == codigo));

            return View("ListaProductos", listaProductos);
        }

        [HttpGet]
        public IActionResult BorrarProducto(int codigo)
        {
            _contexto.Producto.Remove(_contexto.Producto.FirstOrDefault(producto => producto.codigo == codigo));

            _contexto.SaveChanges();

            return View("Index");
        }
    }
}
