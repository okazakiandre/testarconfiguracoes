namespace TestarConfiguracoes.Api.Domain
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public string EmailCliente { get; set; }
        public decimal ValorTotal { get; set; }
        public string Conexao { get; set; }
    }
}
