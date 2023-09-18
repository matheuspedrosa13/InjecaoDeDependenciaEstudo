using InjecaoDeDependencia.Dominio.Repositories.Clientes;
using InjecaoDeDependencia.Dominio.Services.Clientes;
using InjecaoDeDependencia.Dominio.Repositories.Produtos;
using InjecaoDeDependencia.Dominio.Services.Produtos;

namespace InjecaoDeDependencia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ClientesController clientesController = new ClientesController(new ClienteService(new ClienteRepository()));
            ProdutosController produtosController = new ProdutosController(new ProdutoService(new ProdutoRepository()));
            var nomesClientes = clientesController.BuscarPorNome();
            var nomesProdutos = produtosController.BuscarPorNome();

            foreach (var nomeCliente in nomesClientes)
            {
                Console.WriteLine(nomeCliente);
            }            
            foreach (var nomeProdutos in nomesProdutos)
            {
                Console.WriteLine(nomeProdutos);
            }
        }
    }
}
