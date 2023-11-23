using System.Text.Json;
using AutoMapper;
using IFSPFarma.Repository.Context;
using IFSPFarma.Service.Services;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IFSPFarma.Repository.Repository;

namespace IFSPFarma.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPFarma";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Cliente, Cliente>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestCliente()
        {
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Cliente>>();
            var cliente = new Cliente
            {
                Nome = "Joao",
                Senha = "adadawwaafwaf",
                Login = "Arroba0641",
                Email = "jose.arroba@gmail.com"
            };

            var result = _userService?.Add<Cliente, Cliente, ClienteValidator>(cliente);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}