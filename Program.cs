using InjecaoDeDependencia.Dominio.Repositories.Clientes;
using InjecaoDeDependencia.Dominio.Services.Clientes;
using InjecaoDeDependencia.Dominio.Repositories.Produtos;
using InjecaoDeDependencia.Dominio.Services.Produtos;
using InjecaoDeDependencia.Dominio.Repositories.Vendas;
using InjecaoDeDependencia.Dominio.Services.Vendas;

namespace InjecaoDeDependencia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ClientesController clientesController = new ClientesController(new ClienteService(new ClienteRepository()));
            ProdutosController produtosController = new ProdutosController(new ProdutoService(new ProdutoRepository()));
            VendasController vendasController = new VendasController(new VendasService(new VendasRepository()));
            var nomesClientes = clientesController.BuscarPorNome();
            var nomesProdutos = produtosController.BuscarPorNome();
            var nomesVendas = vendasController.BuscarPorNome();

            foreach (var nomeCliente in nomesClientes)
            {
                Console.WriteLine(nomeCliente);
            }            
            foreach (var nomeProdutos in nomesProdutos)
            {
                Console.WriteLine(nomeProdutos);
            }
            foreach (var nomeVendas in nomesVendas)
            {
                Console.WriteLine(nomeVendas);
            }
        }
    }
}
