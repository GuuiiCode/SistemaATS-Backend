using SistemaATS.Domain.Entities;
using System.Collections.Generic;

namespace SistemaATS.Domain.Interfaces.Repositories
{
    public interface ICandidatoRepository
    {
        IEnumerable<Candidato> GetAll();
    }
}
