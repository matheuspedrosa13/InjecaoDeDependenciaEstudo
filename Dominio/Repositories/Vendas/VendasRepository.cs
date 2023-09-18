namespace InjecaoDeDependencia.Dominio.Repositories.Vendas;

public class VendasRepository : IVendasRepository{
    public List<string> BuscarPorNome(){
        List<string> nomesVendas = new List<string>
        {
            "Venda1",
            "Venda2",
            "Venda3"
        };
        return nomesVendas;
    }
}