namespace AppTienda.Models.Repository
{



    public interface IFabricanteRepository
    {
        IEnumerable<Fabricante> GetFabricantes();
        Fabricante GetFabricante(int? codigo);
        void CreateFabricante(Fabricante fabricante);
        void UpdateFabricante(Fabricante fabricante);
        void DeleteFabricante(Fabricante fabricante);
    }




}
