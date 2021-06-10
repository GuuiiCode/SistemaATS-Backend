using SistemaATS.Domain.Entities;

namespace SistemaATS.Domain.Interfaces.Repositories
{
    public interface ICandidatoRepository : IBaseRepository<Candidato>
    {
        Candidato ValidandoSeEmailExiste(string email);
    }
}
