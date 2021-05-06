namespace TestarConfiguracoes.Api.Infrastructure
{
    public interface IEmailClient
    {
        string Enviar(string emailCliente);
    }
}
