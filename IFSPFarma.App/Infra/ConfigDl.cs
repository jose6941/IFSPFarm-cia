using AutoMapper;
using IFSPFarma.App.Cadastro;
using IFSPFarma.App.Models;
using IFSPFarma.App.Outros;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Repository.Context;
using IFSPFarma.Repository;
using IFSPFarma.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IFSPFarma.Repository.Repository;

namespace IFSPFarma.App.Infra
{
    public static class ConfigDl
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Farmaceutico>, BaseRepository<Farmaceutico>>();
            Services.AddScoped<IBaseRepository<Fornecedor>, BaseRepository<Fornecedor>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Remedio>, BaseRepository<Remedio>>();
            Services.AddScoped<IBaseRepository<VendaProduto>, BaseRepository<VendaProduto>>();

            // Services
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Farmaceutico>, BaseService<Farmaceutico>>();
            Services.AddScoped<IBaseService<Fornecedor>, BaseService<Fornecedor>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Remedio>, BaseService<Remedio>>();
            Services.AddScoped<IBaseService<VendaProduto>, BaseService<VendaProduto>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<ClienteCadastro, ClienteCadastro>();          

            // Mapping
            /*
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cliente, ClienteModel>();
                config.CreateMap<Farmaceutico, FarmaceuticoModel>();               
                config.CreateMap<Fornecedor, FornecedorModel>();
                config.CreateMap<Produto, ProdutoModel>()
                    .ForMember(d => d.Fornecedor, d => d.MapFrom(x => x.Forn!.Nome))
                    .ForMember(d => d.IdFornecedor, d => d.MapFrom(x => x.Forn!.Id));
                config.CreateMap<Venda, VendaModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Client!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Client!.Nome))
                    .ForMember(d => d.IdFarmaceutico, d => d.MapFrom(x => x.Farma!.Id))
                    .ForMember(d => d.Farmaceutico, d => d.MapFrom(x => x.Farma!.Nome));
                config.CreateMap<VendaProduto, VendaProduto>()
                    .ForMember(d => d.IdVenda, d => d.MapFrom(x => x.Vend!.Id))
                    .ForMember(d => d.Venda, d => d.MapFrom(x => x.Vend!.Nome))
                    .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));

            }).CreateMapper());
            */
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
