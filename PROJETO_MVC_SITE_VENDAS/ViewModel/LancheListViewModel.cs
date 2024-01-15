using PROJETO_MVC_SITE_VENDAS.Models;

namespace PROJETO_MVC_SITE_VENDAS.ViewModel
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }

        public string CategoriaAtual { get; set; }


    }
}
