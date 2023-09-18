using InjecaoDeDependencia.Dominio.Repositories.Clientes;

namespace InjecaoDeDependencia.Dominio.Services.Clientes;
public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public List<string> BuscarPorNome()
    {
        return _clienteRepository.BuscarPorNome();
    }
}
