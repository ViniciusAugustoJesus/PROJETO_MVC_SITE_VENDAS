using LanchesMac.Models;
using PROJETO_MVC_SITE_VENDAS.Context;
using PROJETO_MVC_SITE_VENDAS.Repositories.Interfaces;

namespace PROJETO_MVC_SITE_VENDAS.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
