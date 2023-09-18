namespace InjecaoDeDependencia.Dominio.Repositories.Produtos;

public class ProdutoRepository : IProdutoRepository
{
    public List<string> BuscarPorNome()
    {
        List<string> nomesProdutos = new List<string>
        {
            "Produto1",
            "Produto2",
            "Produto3"
        };
        return nomesProdutos;
    }
}