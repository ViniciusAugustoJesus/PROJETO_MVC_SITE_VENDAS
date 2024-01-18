using PROJETO_MVC_SITE_VENDAS.Models;
using Microsoft.EntityFrameworkCore;
using PROJETO_MVC_SITE_VENDAS.Models;

namespace PROJETO_MVC_SITE_VENDAS.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; } 
        public DbSet<Lanche> Lanches { get; set; } 

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }



    }
}
