namespace TestarConfiguracoes.Api.Configurations
{
    public class SecaoEmail : ISecaoEmail
    {
        public string Servidor { get; set; }
        public string Remetente { get; set; }
    }
}
