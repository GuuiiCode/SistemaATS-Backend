using AutoMapper;
using SistemaATS.Application.ViewModels;
using SistemaATS.Domain.Entities;

namespace SistemaATS.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<CandidatoViewModel, Candidato>();

            #endregion

            #region DomainToViewModel

            CreateMap<Candidato, CandidatoViewModel>()
                .ForMember(d => d.DataNascimento, opt => opt.MapFrom(src => src.data_nascimento.ToString("dd/MM/yyyy")));

            #endregion
        }
    }
}
