using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPFarma.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(prop => prop.ValorUnitario)
                .IsRequired()
                .HasColumnType("double");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}
