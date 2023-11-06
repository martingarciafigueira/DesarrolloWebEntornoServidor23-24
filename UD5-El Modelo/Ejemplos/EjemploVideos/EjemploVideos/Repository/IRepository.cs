using EjemploVideos.Models;

namespace EjemploVideos.Repository
{
	public interface IRepository
	{
		Task<IEnumerable<Producto>> GetProductos();
		Task<Producto> GetProducto(int? codigoProducto);
		Task CreateProducto(Producto producto);
		Task UpdateProducto(Producto producto);
		Task DeleteProducto(Producto producto);
	}
}
