using InjecaoDeDependencia.Dominio.Services.Vendas;
public class VendasController
{
    private readonly IVendasService _vendasService;

    public VendasController(IVendasService vendasService)
    {
        _vendasService = vendasService;
    }

    public List<string> BuscarPorNome()
    {
        List<string> nomesVendas = _vendasService.BuscarPorNome();
        return nomesVendas;
    }
}
