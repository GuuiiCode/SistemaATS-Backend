using Microsoft.AspNetCore.Mvc;
using SistemaATS.Application.Interfaces.IServices;

namespace SistemaATS.WebApi.Controllers
{
    [Route("api/candidato")]
    [ApiController]
    public class CanditadoController : ControllerBase
    {
        private readonly ICandidatoService _candidatoService;

        public CanditadoController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        { 
            return Ok(_candidatoService.GetAll());
        }
    }
}
