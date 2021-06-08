using System.Collections.Generic;

namespace SistemaATS.Domain.Entities
{
    public class Endereco : BaseEntity<int>
    {
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        
        public ICollection<Candidato> candidato_tb { get; set; }
    }
}
