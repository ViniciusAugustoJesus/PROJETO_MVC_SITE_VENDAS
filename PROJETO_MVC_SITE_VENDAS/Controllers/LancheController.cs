using Microsoft.AspNetCore.Mvc;
using PROJETO_MVC_SITE_VENDAS.Repositories.Interfaces;
using PROJETO_MVC_SITE_VENDAS.ViewModel;

namespace PROJETO_MVC_SITE_VENDAS.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria atual";

            return View(lanchesListViewModel);
        }
    }
}
