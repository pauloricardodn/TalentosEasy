using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;
using TalentosEasy.Dominio.Interfaces.Repositorios;
using TalentosEasy.Dominio.Interfaces.Services;

namespace TalentosEasy.Dominio.Services
{
    public class CandidatoService: ICandidatoService
    {
        private readonly ICandidatoRepositorio _candidatoRepositorio;

        public CandidatoService(ICandidatoRepositorio candidatoRepositorio)
        {
            _candidatoRepositorio = candidatoRepositorio;
        }

        public void Add(Candidato candidato)
        {
            _candidatoRepositorio.Add(candidato);
        }

        public Candidato GetById(int id)
        {
            return _candidatoRepositorio.GetById(id);
        }

        public IEnumerable<Candidato> GetAll()
        {
            return _candidatoRepositorio.GetAll();
        }

        public void Update(Candidato candidato)
        {
            _candidatoRepositorio.Update(candidato);
        }

        public void Remove(Candidato candidato)
        {
            _candidatoRepositorio.Remove(candidato);
        }        
    }
}
