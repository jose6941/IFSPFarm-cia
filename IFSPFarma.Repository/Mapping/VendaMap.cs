using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPFarma.Repository.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data)
                .IsRequired();

            builder.HasMany(prop => prop.Produtos);

            builder.Property(prop => prop.TotalVenda);
            builder.HasOne(prop => prop.Cliente);
            builder.HasOne(prop => prop.Farmaceutico);
        }
    }
}
