using LanchesMac.Models;

namespace PROJETO_MVC_SITE_VENDAS.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
