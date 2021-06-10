using AutoMapper;
using Moq;
using SistemaATS.Application.AutoMapper;
using SistemaATS.Application.Services;
using SistemaATS.Application.ViewModels;
using SistemaATS.Domain.Entities;
using SistemaATS.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace SistemaATS.Application.Tests.Services
{
    public class CandidatoServiceTests
    {
        private CandidatoService _candidatoService;

        public CandidatoServiceTests()
        {
            _candidatoService = new CandidatoService(new Mock<ICandidatoRepository>().Object, new Mock<IMapper>().Object);
        }

        #region Validando Id

        [Fact]
        public void Post_EnviandoValidacaoId()
        { 
            var excption = Assert.Throws<Exception>(() => _candidatoService.Post(new CandidatoViewModel { Id = 9999 }));
            Assert.Equal("Para inserir um Candidato o ID não deve ser preenchido", excption.Message);
        }

        [Fact]
        public void GetById_EnviandoIdNull()
        {
            var exception = Assert.Throws<Exception>(() => _candidatoService.GetById(0));
            Assert.Equal("Candidato Id não encontrado", exception.Message);
        }

        [Fact]
        public void Put_EnviandoIdNull()
        {
            var exception = Assert.Throws<Exception>(() => _candidatoService.Put(new CandidatoViewModel()));
            Assert.Equal("Candidato Id não encontrado", exception.Message);
        }

        [Fact]
        public void Delete_EnviandoIdNull()
        {
            var exception = Assert.Throws<Exception>(() => _candidatoService.Delete(0));
            Assert.Equal("Candidato Id não encontrado", exception.Message);
        }

        #endregion

        #region Validando envio de objeto válido
        
        [Fact]
        public void Post_EnviandoValidacaoObjeto()
        {
            var result = _candidatoService.Post(new CandidatoViewModel 
            { 
                Nome = "Guilherme", Email = "guilherme@gmail.com", Telefone = "915975369", DataNascimento = "05/05/1984", Genero = "M"
            });

            Assert.True(result);
        }

        [Fact]
        public void Get_ValidandoObjeto()
        {
            var candidatos = new List<Candidato>();
            candidatos.Add(new Candidato 
            { 
                id = 9999, nome = "Guilherme", email = "guilherme@gmail.com", telefone = "915975369", data_nascimento = Convert.ToDateTime("05/05/1984"), genero = "M" 
            });

            var candidatoRepository = new Mock<ICandidatoRepository>();
            candidatoRepository.Setup(x => x.GetAll()).Returns(candidatos);
             
            var autoMapper = new AutoMapperSetup();
            var configuration = new MapperConfiguration(x => x.AddProfile(autoMapper));
            var mapper = new Mapper(configuration);

            _candidatoService = new CandidatoService(candidatoRepository.Object, mapper);
            var result = _candidatoService.GetAll();
            Assert.True(result.Count > 0);
        }

        #endregion

        #region Validando campos obrigatórios

        [Fact]
        public void Post_EnviandoObjetoInvalido()
        {
            var result = Assert.Throws<ValidationException>(() => _candidatoService.Post(new CandidatoViewModel { Nome = "Guilherme" }));
            Assert.Equal("Preencha o campo Email", result.Message);
        }

        #endregion
    }
}
