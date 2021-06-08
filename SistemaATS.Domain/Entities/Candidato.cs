using System;

namespace SistemaATS.Domain.Entities
{
    public class Candidato : BaseEntity<int>
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string genero { get; set; }
        public DateTime data_nascimento { get; set; }
        public int endereco_id { get; set; }

        public Endereco endereco_tb { get; set; }
    }
}
