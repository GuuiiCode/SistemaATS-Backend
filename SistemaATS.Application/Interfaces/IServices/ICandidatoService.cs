using SistemaATS.Application.ViewModels;
using System.Collections.Generic;

namespace SistemaATS.Application.Interfaces.IServices
{
    public interface ICandidatoService
    {
        List<CandidatoViewModel> GetAll();
        bool Post(CandidatoViewModel candidatoViewModel);
        CandidatoViewModel GetById(int id);
        bool Put(CandidatoViewModel candidatoViewModel);
        bool Delete(int id);
    }
}
