using System.Collections.Generic;

namespace SistemaATS.Domain.Entities
{
    public class endereco_tb : BaseEntity<int>
    {
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        
        public ICollection<candidato_tb> candidato_tb { get; set; }
    }
}
