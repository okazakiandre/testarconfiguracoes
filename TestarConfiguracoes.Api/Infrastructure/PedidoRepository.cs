using Microsoft.Extensions.Configuration;
using System;
using TestarConfiguracoes.Api.Configurations;
using TestarConfiguracoes.Api.Domain;

namespace TestarConfiguracoes.Api.Infrastructure
{
    public class PedidoRepository : IPedidoRepository
    {
        private ISecaoMongoDb Config { get; }

        public PedidoRepository(ISecaoMongoDb cfg)
        {
            Config = cfg;
        }

        public Pedido Obter(int codigo)
        {
            var conex = Config.ConnectionString;
            if (conex is null)
            {
                throw new Exception("O arquivo de configuração não tem a connection string.");
            }
            return new Pedido
            { 
                Codigo = codigo,
                ValorTotal = 1233.34m,
                EmailCliente = "cliente@email.com",
                Conexao = conex
            };
        }
    }
}
