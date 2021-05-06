using TestarConfiguracoes.Api.Domain;

namespace TestarConfiguracoes.Api.Infrastructure
{
    public interface IPedidoRepository
    {
        Pedido Obter(int codigo);
    }
}
