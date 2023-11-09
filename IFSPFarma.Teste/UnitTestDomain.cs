using System.Text.Json;
using IFSPFarmacia.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFSPFarma.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCliente()
        {
            var cliente = new Cliente
            {
                Nome = "Joao",
                Senha = "adadawwaafwaf",
                Login = "Arroba0641",
                Email = "jose.arroba@gmail.com"
            };

            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Batatais");
            Assert.AreEqual(cliente.Senha, "adadawwaafwaf");
            Assert.AreEqual(cliente.Login, "Arroba0641");
            Assert.AreEqual(cliente.Email, "jose.arroba@gmail.com");

        }
        [TestMethod]
        public void TestFarmaceutico()
        {
            var farmaceutico = new Farmaceutico();
            
            farmaceutico.Nome = "Giuliano";
            farmaceutico.Endereco = "Altino Vaz de Mello";
            farmaceutico.Idade = 21;

            Console.WriteLine(JsonSerializer.Serialize(farmaceutico));
            Assert.AreEqual(farmaceutico.Nome, "Giuliano");
            Assert.AreEqual(farmaceutico.Endereco, "Altino Vaz de Mello");
            Assert.AreEqual(farmaceutico.Idade, 21);          

        }
        [TestMethod]
        public void TesteFornecedor()
        {
            var fornecedor = new Fornecedor();

            fornecedor.Nome = "Tiago";
            fornecedor.Cnpj = "446546545448";
            fornecedor.Razaosocial = "FarmaCon";

            Console.WriteLine(JsonSerializer.Serialize(fornecedor));
            Assert.AreEqual(fornecedor.Nome, "Tiago");
            Assert.AreEqual(fornecedor.Cnpj, "446546545448");
            Assert.AreEqual(fornecedor.Razaosocial, "FarmaCon");

        }
        [TestMethod]
        public void TesteProduto()
        {
            var produto = new Produto();

            produto.Quantidade = 5;
            produto.ValorUnitario = 54.60;
            produto.ValorTotal = 273.00;


        }

    }

}