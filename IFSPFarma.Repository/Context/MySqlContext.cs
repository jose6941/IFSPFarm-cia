using IFSPFarmacia.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace IFSPFarma.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Farmaceutico>? Farmaceutico { get; set; }
        public DbSet<Fornecedor>? Fornecedor { get; set; }
        public DbSet<VendaProduto>? Pedido { get; set; }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<Remedio>? Remedio { get; set; }
        public DbSet<Venda>? Venda { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Farmaceutico>(new FarmaceuticoMap().Configure);
            modelBuilder.Entity<Fornecedor>(new FornecedorMap().Configure);
            modelBuilder.Entity<VendaProduto>(new VendaProdutoMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Remedio>(new RemedioMap().Configure);
            modelBuilder.Entity<Venda>(new VendaMap().Configure);
        }
    }
}
