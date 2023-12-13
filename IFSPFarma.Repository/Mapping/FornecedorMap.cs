using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPFarma.Repository.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Cnpj)
                .IsRequired();

            builder.Property(prop => prop.Razaosocial)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}
