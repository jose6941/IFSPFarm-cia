using System.Text.Json;
using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IFSPSFarma.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Farmaceutico> Farmaceutico { get; set; }
            public DbSet<Fornecedor> Fornecedor { get; set; }
            public DbSet<Produto> Produto { get; set; }
            public DbSet<Remedio> Remedio { get; set; }
            public DbSet<Venda> Venda { get; set; }
            public DbSet<VendaProduto> VendaProduto { get; set; }

            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }

            [TestMethod]
            public void TestInsertClientes()
            {
                using (var context = new MyDbContext())
                {

                    var cliente = new Cliente
                    {
                        Nome = "Joao",
                        Senha = "adadawwaafwaf",
                        Login = "Arroba0641",
                        Email = "joao.arroba@gmail.com"
                    };
                    context.Cliente.Add(cliente);

                    cliente = new Cliente
                    {
                        Nome = "Jose",                       
                        Senha = "123",
                        Login = "Arroba",
                        Email = "jose.arroba@gmail.com"
                    };
                    context.Cliente.Add(cliente);

                    context.SaveChanges();
                }
            }

            [TestMethod]
            public void TestListarClientes()
            {
                using (var context = new MyDbContext())
                {
                    foreach (var cliente in context.Cliente)
                    {
                        Console.WriteLine(JsonSerializer.Serialize(cliente));
                    }
                }
            }
        }
    }
}   