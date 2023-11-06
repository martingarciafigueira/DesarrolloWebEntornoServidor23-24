using EjemploFutbol.Models.Repositories;
using Ejercicio1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploFabricante.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly IFabricanteRepository _fabricanteRepository;

        public FabricanteController(IFabricanteRepository fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository;
        }

        public async Task<IActionResult> Index()
        {
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Data = await _fabricanteRepository.GetFabricantes();
            return View("Index", Data);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int codigo)
        {
            var fabricante = await _fabricanteRepository.GetFabricante(codigo);
            return View("VerFabricante", fabricante);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Fabricante fabricante)
        {
            await _fabricanteRepository.CreateFabricante(fabricante);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int codigo)
        {
            var fabricante = await _fabricanteRepository.GetFabricante(codigo);
            return View(fabricante);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Fabricante fabricante)
        {
            await _fabricanteRepository.UpdateFabricante(fabricante);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int codigo)
        {
            var fabricante = await _fabricanteRepository.GetFabricante(codigo);
            return View(fabricante);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Fabricante fabricante)
        {
            await _fabricanteRepository.DeleteFabricante(fabricante);
            return RedirectToAction("Index");
        }
    }
}
