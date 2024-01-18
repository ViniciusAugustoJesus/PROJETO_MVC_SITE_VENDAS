using Microsoft.AspNetCore.Mvc;
using PROJETO_MVC_SITE_VENDAS.Models;
using PROJETO_MVC_SITE_VENDAS.Repositories.Interfaces;
using PROJETO_MVC_SITE_VENDAS.ViewModel;

namespace PROJETO_MVC_SITE_VENDAS.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItems();

            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);

            if(lancheSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinho(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);

            if (lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
