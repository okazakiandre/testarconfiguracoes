using Microsoft.AspNetCore.Mvc;
using TestarConfiguracoes.Api.Configurations;
using TestarConfiguracoes.Api.Infrastructure;

namespace TestarConfiguracoes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private IPedidoRepository PedRepo { get; }
        private IEmailClient EmailCli { get; }

        public PedidosController(IPedidoRepository repo, IEmailClient eml)
        {
            PedRepo = repo;
            EmailCli = eml;
        }

        [HttpPost]
        public IActionResult Finalizar(FinalizarPedidoRequest req)
        {
            var ped = PedRepo.Obter(req.CodigoPedido);
            var msg = EmailCli.Enviar(ped.EmailCliente);
            return Ok(new { mensagem = $"Pedido finalizado! {msg}" });
        }
    }
}
