using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TestarConfiguracoes.Api.Configurations;
using TestarConfiguracoes.Api.Infrastructure;

namespace TestarConfiguracoes.UnitTest
{
    [TestClass]
    [TestCategory("UnitTest > Infrastructure > Repositories")]
    public class PedidoRepositoryTest
    {
        [TestMethod]
        public void DeveriaOcorrerErroSeNaoHouverConnectionString()
        {
            var mockSecMongo = new Mock<ISecaoMongoDb>();
            var ped = new PedidoRepository(mockSecMongo.Object);
            var exc = Assert.ThrowsException<Exception>(() => ped.Obter(1));
            Assert.AreEqual("O arquivo de configuração não tem a connection string.", exc.Message);
        }

        [TestMethod]
        public void DeveriaRetornarPedido()
        {
            var mockSecMongo = new Mock<ISecaoMongoDb>();
            mockSecMongo.SetupGet(m => m.ConnectionString).Returns("sss");
            var ped = new PedidoRepository(mockSecMongo.Object);
            var ret = ped.Obter(1);
            Assert.AreEqual("sss", ret.Conexao);
        }
    }
}
