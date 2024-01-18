using PROJETO_MVC_SITE_VENDAS.Models;

namespace PROJETO_MVC_SITE_VENDAS.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }

        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheById(int lancheId);


    }
}
