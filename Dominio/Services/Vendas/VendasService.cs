using InjecaoDeDependencia.Dominio.Repositories.Vendas;
namespace InjecaoDeDependencia.Dominio.Services.Vendas;

public class VendasService : IVendasService
{
    private readonly IVendasRepository _vendasRepository;

    public VendasService(IVendasRepository vendasRepository)
    {
        _vendasRepository = vendasRepository;
    }

    public List<string> BuscarPorNome()
    {
        return _vendasRepository.BuscarPorNome();
    }
}