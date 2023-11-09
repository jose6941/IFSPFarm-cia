using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class VendaProdutoMap : IEntityTypeConfiguration<VendaProduto>
    {
        public void Configure(EntityTypeBuilder<VendaProduto> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Total)
                .IsRequired()
                .HasColumnType("double");

            builder.Property(prop => prop.Desconto)
                .IsRequired()
                .HasColumnType("double");

            builder.Property(prop => prop.Quantidade)
                 .IsRequired()
                 .HasColumnType("integer");
        }
    }
}
