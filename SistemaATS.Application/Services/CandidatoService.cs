using AutoMapper;
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
        private readonly IMapper _mapper;

        public CandidatoService(ICandidatoRepository candidatoRepository,
                                IMapper mapper)
        {
            _candidatoRepository = candidatoRepository;
            _mapper = mapper;
        }

        public List<CandidatoViewModel> GetAll()
        {
            var candidatoViewModels = new List<CandidatoViewModel>();
            
            var candidatos = _candidatoRepository.GetAll();

            candidatoViewModels = _mapper.Map<List<CandidatoViewModel>>(candidatos);

            //foreach (var item in candidatos)
            //{
            //    //candidatoViewModels.Add(new CandidatoViewModel 
            //    //{ 
            //    //    Id = item.id,
            //    //    Nome = item.nome,
            //    //    Email = item.email,
            //    //    Telefone = item.telefone,
            //    //    Genero = item.genero,
            //    //    DataNascimento = item.data_nascimento.ToString("dd/MM/yyyy")
            //    //});

            //    candidatoViewModels.Add(_mapper.Map<CandidatoViewModel>(item));
            //}

            return candidatoViewModels;
        }

        public bool Post(CandidatoViewModel candidatoViewModel)
        {
            //Candidato candidato = new Candidato
            //{ 
            //    nome = candidatoViewModel.Nome,
            //    email = candidatoViewModel.Email,
            //    telefone = candidatoViewModel.Telefone,
            //    genero = candidatoViewModel.Genero,
            //    data_nascimento = DateTime.Parse(candidatoViewModel.DataNascimento)
            //};

            var candidato = _mapper.Map<Candidato>(candidatoViewModel);

            _candidatoRepository.Add(candidato);

            return true;
        }
    }
}
