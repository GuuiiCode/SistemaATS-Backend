using Microsoft.Extensions.DependencyInjection;
using SistemaATS.Application.Interfaces.IServices;
using SistemaATS.Application.Services;
using SistemaATS.Data.Repositories;
using SistemaATS.Domain.Interfaces.Repositories;

namespace SistemaATS.DryIoc
{
    public static class InjectionDependencies
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<ICandidatoService, CandidatoService>();

            #endregion

            #region Repositories

            services.AddScoped<ICandidatoRepository, CandidatoRepository>();

            #endregion
        }
    }
}
