using System.ComponentModel.DataAnnotations;

namespace SistemaATS.Application.ViewModels
{
    public class CandidatoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data Nascimento")]
        public string DataNascimento { get; set; }
    }
}