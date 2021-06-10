using SistemaATS.Data.Context;
using SistemaATS.Domain.Entities;
using SistemaATS.Domain.Interfaces.Repositories;
using System.Linq;

namespace SistemaATS.Data.Repositories
{
    public class CandidatoRepository : BaseRepository<Candidato>, ICandidatoRepository
    {
        private ATSContext db = null;

        public CandidatoRepository(ATSContext context)
            : base(context) 
        {
            db = context;
        }

        public Candidato ValidandoSeEmailExiste(string email)
        {
            var result = db.Candidatos.FirstOrDefault(x => x.email.Contains(email));

            return result;
        }
    }
}
