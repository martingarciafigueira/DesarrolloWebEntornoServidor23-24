using Ejercicio1.Models;

namespace EjemploFutbol.Models.Repositories
{

    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductos();
    }

}
