using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaATS.Domain.Entities;

namespace SistemaATS.Data.Configuration
{
    public class CandidatoConfiguration : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> entity)
        {
            entity.HasKey(e => e.id);

            entity.Property(e => e.nome)
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.email)
                  .HasMaxLength(150)
                  .IsRequired();

            entity.Property(e => e.telefone)
                  .HasMaxLength(17)
                  .IsRequired();

            entity.Property(e => e.genero)
                  .HasMaxLength(1)
                  .IsRequired();

            entity.Property(e => e.data_nascimento)
                  .HasColumnType("datetime")
                  .IsRequired();

            //entity.HasOne(e => e.endereco_tb)
            //      .WithMany(e => e.candidato_tb)
            //      .HasForeignKey(f => f.endereco_id);

        }
    }
}
