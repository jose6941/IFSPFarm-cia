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
           
            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Fornecedor);
            builder.HasOne(prop => prop.Remedio);
        }
    }
}
