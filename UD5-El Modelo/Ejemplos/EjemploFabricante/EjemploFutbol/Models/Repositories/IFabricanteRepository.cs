using Ejercicio1.Models;

namespace EjemploFutbol.Models.Repositories
{

    public interface IFabricanteRepository
    {
        Task<IEnumerable<Fabricante>> GetFabricantes();
        Task<Fabricante> GetFabricante(int? codigo);
        Task CreateFabricante(Fabricante fabricante);
        Task UpdateFabricante(Fabricante fabricante);
        Task DeleteFabricante(Fabricante fabricante);
    }

}
