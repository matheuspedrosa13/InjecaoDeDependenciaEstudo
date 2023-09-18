using InjecaoDeDependencia.Dominio.Services.Produtos;
public class ProdutosController
{
    private readonly IProdutoService _produtoService;

    public ProdutosController(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    public List<string> BuscarPorNome()
    {
        List<string> nomesClientes = _produtoService.BuscarPorNome();
        return nomesClientes;
    }
}
