using System.ComponentModel.DataAnnotations;

namespace SistemaATS.Application.ViewModels
{
    public class CandidatoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MinLength(9, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(17, ErrorMessage = "Máximo {0} caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Genero")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data Nascimento")]
        public string DataNascimento { get; set; }
    }
}
