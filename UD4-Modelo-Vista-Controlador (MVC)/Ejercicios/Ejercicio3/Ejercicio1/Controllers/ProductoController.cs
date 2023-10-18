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
            List<Producto> listaProductos = new List<Producto>();

            var productos = from producto in _contexto.Producto
                              select producto;
            listaProductos = productos.AsEnumerable().ToList();

            return View("Index", listaProductos);
        }

        public IActionResult VerProducto(int id)
        {
            List<Producto> listaProductos = new List<Producto>();

            listaProductos.Add(_contexto.Producto.FirstOrDefault(producto => producto.codigo == id));

            return View("ListaProductos", listaProductos);
        }
    }
}
