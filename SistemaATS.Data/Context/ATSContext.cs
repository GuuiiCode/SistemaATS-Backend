using Microsoft.EntityFrameworkCore;
using SistemaATS.Data.Configuration;
using SistemaATS.Domain.Entities;

namespace SistemaATS.Data.Context
{
    public class ATSContext : DbContext
    {
        public ATSContext(DbContextOptions<ATSContext> options)
            : base(options) { }

        public DbSet<candidato_tb> Candidatos { get; set; }
        public DbSet<endereco_tb> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidatoConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
