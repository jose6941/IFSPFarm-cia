using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPFarma.Repository.Mapping
{
    public class VendaProdutoMap : IEntityTypeConfiguration<VendaProduto>
    {
        public void Configure(EntityTypeBuilder<VendaProduto> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Total)
                .IsRequired();

            builder.Property(prop => prop.ValorUnit)
                .IsRequired();

            builder.Property(prop => prop.Desconto)
                .IsRequired();

            builder.Property(prop => prop.Quantidade)
                 .IsRequired();

            builder.HasOne(prop => prop.Vend)
              .WithMany(prop => prop.Produtos)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(prop => prop.Prod);
        }
    }
}
