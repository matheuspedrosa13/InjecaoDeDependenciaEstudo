using InjecaoDeDependencia.Dominio.Services.Clientes;

public class ClientesController
{
    private readonly IClienteService _clienteService;

    public ClientesController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    public List<string> BuscarPorNome()
    {
        List<string> nomesClientes = _clienteService.BuscarPorNome();
        return nomesClientes;
    }
}
