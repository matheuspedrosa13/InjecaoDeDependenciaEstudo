using InjecaoDeDependencia.Dominio.Repositories.Produtos;
namespace InjecaoDeDependencia.Dominio.Services.Produtos;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public List<string> BuscarPorNome()
    {
        return _produtoRepository.BuscarPorNome();
    }
}