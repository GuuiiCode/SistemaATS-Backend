using SistemaATS.Application.ViewModels;
using System.Collections.Generic;

namespace SistemaATS.Application.Interfaces.IServices
{
    public interface ICandidatoService
    {
        List<CandidatoViewModel> GetAll();
    }
}
