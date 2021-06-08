using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaATS.Domain.Entities;

namespace SistemaATS.Data.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> entity)
        {
            entity.HasKey(e => e.id);

            entity.Property(e => e.rua)
                  .HasMaxLength(70)
                  .IsRequired();

            entity.Property(e => e.bairro)
                  .HasMaxLength(70)
                  .IsRequired();

            entity.Property(e => e.cidade)
                  .HasMaxLength(50)
                  .IsRequired();

            entity.Property(e => e.estado)
                  .HasMaxLength(2)
                  .IsRequired();

            entity.Property(e => e.cep)
                  .HasMaxLength(9)
                  .IsRequired();

        }
    }
}
