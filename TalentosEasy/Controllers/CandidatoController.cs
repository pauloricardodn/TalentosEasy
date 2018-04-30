using System;
using System.Collections.Generic;
using System.Web.Http;
using TalentosEasy.Dominio.Entidades;
using TalentosEasy.Dominio.Interfaces.Repositorios;
using TalentosEasy.Dominio.Interfaces.Services;

namespace TalentosEasy.Controllers
{
    public class CandidatoController : ApiController
    {
        private readonly ICandidatoService _candidatoService;
        private readonly ICandidatoRepositorio _candidatoRepositorio;

        public CandidatoController(ICandidatoService candidatoService, ICandidatoRepositorio candidatoRepositorio)
        {
            _candidatoService = candidatoService;
            _candidatoRepositorio = candidatoRepositorio;
        }
        // GET: api/Candidato
        public IHttpActionResult Get()
        {
            try
            {
                var response = _candidatoRepositorio.GetAll();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ops! algo deu errado! Erro: {ex.Message}");
            }
        }

        // GET: api/Candidato/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var response = _candidatoRepositorio.GetById(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ops! algo deu errado! Erro: {ex.Message}");
            }
        }

        // POST: api/Candidato
        public IHttpActionResult Post(Candidato candidato)
        {
            try
            {
         //       _agenciaRepository.PostAgencia(candidato);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ops! algo deu errado! Erro: {ex.Message}");
            }
            return Ok();
        }

        // PUT: api/Candidato/5
        public IHttpActionResult Put(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ops! algo deu errado! Erro: {ex.Message}");
            }
        }

        // DELETE: api/Candidato/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ops! algo deu errado! Erro: {ex.Message}");
            }
        }
    }
}
