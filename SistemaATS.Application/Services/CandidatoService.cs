using SistemaATS.Application.Interfaces.IServices;
using SistemaATS.Application.ViewModels;
using SistemaATS.Domain.Entities;
using SistemaATS.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SistemaATS.Application.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public List<CandidatoViewModel> GetAll()
        {
            List<CandidatoViewModel> candidatoViewModels = new List<CandidatoViewModel>();
            
            IEnumerable<Candidato> candidatos = _candidatoRepository.GetAll();

            foreach(var item in candidatos)
            {
                candidatoViewModels.Add(new CandidatoViewModel 
                { 
                    Id = item.id,
                    Nome = item.nome,
                    Email = item.email,
                    Telefone = item.telefone,
                    Genero = item.genero,
                    DataNascimento = item.data_nascimento.ToString("dd/MM/yyyy")
                });
            }

            return candidatoViewModels;
        }
    }
}
