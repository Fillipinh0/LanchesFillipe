using LanchesFillipe.Repositories;
using LanchesFillipe.Repositories.Interfaces;
using LanchesFillipe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LanchesFillipe.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;
        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Todos os Lanches";

            return View(lanchesListViewModel);
        }
    }
}
