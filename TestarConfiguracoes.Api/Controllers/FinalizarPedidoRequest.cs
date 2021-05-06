namespace TestarConfiguracoes.Api.Controllers
{
    public class FinalizarPedidoRequest
    {
        public int CodigoPedido { get; set; }
        public long CpfCliente { get; set; }
    }
}
