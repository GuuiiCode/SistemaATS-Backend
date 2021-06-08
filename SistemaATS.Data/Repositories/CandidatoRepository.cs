using SistemaATS.Data.Context;
using SistemaATS.Domain.Entities;
using SistemaATS.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SistemaATS.Data.Repositories
{
    public class CandidatoRepository : BaseRepository<Candidato>, ICandidatoRepository
    { 
        public CandidatoRepository(ATSContext context)
            : base(context) { }

        public IEnumerable<Candidato> ListAll()
        {
            return GetAll();
        }
    }
}
