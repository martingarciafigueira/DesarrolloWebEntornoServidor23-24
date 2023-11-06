using Ejercicio1.Models;

namespace EjemploFutbol.Models.Repositories
{

    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductos();
        Task<Producto> GetProducto(int? codigo);
        Task UpdateProducto(Producto producto);

    }

}
