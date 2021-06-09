﻿using Microsoft.AspNetCore.Mvc;
using SistemaATS.Application.Interfaces.IServices;
using SistemaATS.Application.ViewModels;

namespace SistemaATS.WebApi.Controllers.v1
{
    [Route("v1/api/candidato")]
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

        [HttpPost]
        public IActionResult Post(CandidatoViewModel candidatoViewModel)
        {
            return Ok(_candidatoService.Post(candidatoViewModel));
        }
    }
}