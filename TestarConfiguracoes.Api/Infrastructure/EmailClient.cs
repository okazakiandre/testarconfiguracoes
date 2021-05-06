using Microsoft.Extensions.Configuration;

namespace TestarConfiguracoes.Api.Infrastructure
{
    public class EmailClient : IEmailClient
    {
        private IConfiguration Config { get; }

        public EmailClient(IConfiguration cfg)
        {
            Config = cfg;
        }

        public string Enviar(string emailCliente)
        {
            var remetente = Config.GetSection("email")["remetente"];
            var servidor = Config.GetSection("email")["servidor"];
            return $"Email enviado de {remetente} para {emailCliente}, do servidor {servidor}.";
        }
    }
}
