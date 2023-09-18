namespace InjecaoDeDependencia.Dominio.Repositories.Clientes;

public class ClienteRepository : IClienteRepository
{
    public List<string> BuscarPorNome()
    {
        List<string> nomesClientes = new List<string>
        {
            "Cliente1",
            "Cliente2",
            "Cliente3"
        };

        return nomesClientes;
    }
}