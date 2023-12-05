using AppTienda.Models;
using AppTienda.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AppTienda.Controllers
{
	public class FabricanteController : Controller
	{
		private readonly IFabricanteRepository _fabricanteRepository;

		public FabricanteController(IFabricanteRepository productoRepository)
		{
			_fabricanteRepository = productoRepository;
		}

		public IActionResult Index()
		{
			return RedirectToAction("GetAll");
		}

		[HttpGet]
        public IActionResult GetAll()
        {
            //Creo la lista
            List<Fabricante> listaFabricantes = new List<Fabricante>();

            //Llamo al modelo, obtengo todos los fabricantes y los meto en la lista
            listaFabricantes = (List<Fabricante>)_fabricanteRepository.GetFabricantes();

            //Le paso la lista a la vista
            return View(listaFabricantes);
        }

        public IActionResult Details(int codigo)
		{
			//Llamo al modelo, obtengo un fabricante
			Fabricante fab = _fabricanteRepository.GetFabricante(codigo);

			return View(fab);
		}

		[HttpGet]
		public IActionResult Edit(int codigo)
		{
			//Llamo al modelo, obtengo un fabricante
			Fabricante fab = _fabricanteRepository.GetFabricante(codigo);

			return View(fab);
		}

		[HttpPost]
		public IActionResult Edit(Fabricante fab)
		{
			//Llamo al modelo, actualizo un fabricante
			_fabricanteRepository.UpdateFabricante(fab);

            return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Fabricante fabricante)
		{
			//Llamo al modelo, inserto un fabricante
			_fabricanteRepository.CreateFabricante(fabricante);
            return RedirectToAction("Index");
        }

		[HttpGet]
		public IActionResult Delete(int codigo)
		{
			//Llamo al modelo, obtengo un fabricante
			Fabricante fab = _fabricanteRepository.GetFabricante(codigo);
			return View(fab);
		}
		[HttpPost]
		public IActionResult Delete(Fabricante fab)
		{
			//Llamo al modelo, borro un fabricante
			_fabricanteRepository.DeleteFabricante(fab);
			return RedirectToAction("Index");
		}
	}
}
