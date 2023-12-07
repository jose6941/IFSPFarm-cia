using IFSPFarmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPFarma.Repository.Mapping
{
    public class FarmaceuticoMap : IEntityTypeConfiguration<Farmaceutico>
    {
        public void Configure(EntityTypeBuilder<Farmaceutico> builder)
        {
            builder.ToTable("Farmaceutico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Idade)
                .IsRequired();    
        }
    }
}
