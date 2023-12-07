using System.Text.Json;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCliente()
        {
            var cliente = new Cliente();

            cliente.Nome = "Joao";
            cliente.Senha = "adadawwaafwaf";
            cliente.Login = "Arroba0641";
            cliente.Email = "jose.arroba@gmail.com";
            
            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Joao");
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
            var fornecedor = new Fornecedor();
            var remedio = new Remedio();

            produto.Quantidade = 5;
            produto.ValorUnitario = 54.60;
            //produto.ValorTotal = 273.00;

            fornecedor.Nome = "Tiago";
            fornecedor.Cnpj = "446546545448";
            fornecedor.Razaosocial = "FarmaCon";

            remedio.Nome = "Dipirona";


        }

        [TestMethod]

        public void Remedio()
        {
            var remedio = new Remedio();

            remedio.Nome = "Dipirona";
            Console.WriteLine(JsonSerializer.Serialize(remedio));
            Assert.AreEqual(remedio.Nome, "Dipirona");
        }

        [TestMethod]

        public void Venda()
        {
            var venda = new Venda();    
            var cliente = new Cliente();    
            var farmaceutico = new Farmaceutico();

            venda.Data = DateTime.Today;

            cliente.Nome = "Joao";
            cliente.Senha = "adadawwaafwaf";
            cliente.Login = "Arroba0641";
            cliente.Email = "jose.arroba@gmail.com";

            farmaceutico.Nome = "Giuliano";
            farmaceutico.Endereco = "Altino Vaz de Mello";
            farmaceutico.Idade = 21;

            Console.WriteLine(JsonSerializer.Serialize(venda));
            Assert.AreEqual(venda.Data, DateTime.Today);
        }

        [TestMethod]

        public void VendaProduto()
        {
            var vendaproduto = new VendaProduto();
            var venda = new Venda();
            var produto = new Produto();

            vendaproduto.Total = 2580.50;
            vendaproduto.Desconto = 258.50;
            vendaproduto.Quantidade = 5;

            Console.WriteLine(JsonSerializer.Serialize(vendaproduto));
            Assert.AreEqual(vendaproduto.Total, 2580.50);
            Assert.AreEqual(vendaproduto.Desconto, 258.50);
            Assert.AreEqual(vendaproduto.Quantidade, 5);
        }
    }

}