using AutoMapper;
using SistemaATS.Application.Interfaces.IServices;
using SistemaATS.Application.ViewModels;
using SistemaATS.Domain.Entities;
using SistemaATS.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

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

            return candidatoViewModels;
        }

        public CandidatoViewModel GetById(int id)
        {
            var candidato = _candidatoRepository.GetById(id);

            if (candidato == null)
                throw new Exception("Candidato Id não encontrado");
             
            return _mapper.Map<CandidatoViewModel>(candidato);
        }

        public bool Post(CandidatoViewModel candidatoViewModel)
        {
            if(candidatoViewModel.Id != 0)
                throw new Exception("Para inserir um Candidato o ID não deve ser preenchido");

            Validator.ValidateObject(candidatoViewModel, new ValidationContext(candidatoViewModel), true);

            var emailExiste = _candidatoRepository.ValidandoSeEmailExiste(candidatoViewModel.Email);

            if (emailExiste != null)
                throw new Exception("O email informado já está cadastrado na base");

            var candidato = _mapper.Map<Candidato>(candidatoViewModel);

            _candidatoRepository.Add(candidato);

            return true;
        }

        public bool Put(CandidatoViewModel candidatoViewModel)
        {
            var candidato = _candidatoRepository.GetById(x => x.id == candidatoViewModel.Id);

            if (candidato == null)
                throw new Exception("Candidato Id não encontrado");

            candidato = _mapper.Map<Candidato>(candidatoViewModel);
              
            _candidatoRepository.Update(candidato);

            return true;
        }
         
        public bool Delete(int id)
        {
            var candidato = _candidatoRepository.GetById(x => x.id == id);
             
            if (candidato == null)
                throw new Exception("Candidato Id não encontrado");
              
            _candidatoRepository.Remove(candidato);

            return true;
        }
    }
}
