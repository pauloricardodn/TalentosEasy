using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;

namespace TalentosEasy.Dominio.Interfaces.Services
{
    public interface ICandidatoService
    {
        void Add(Candidato candidato);
        Candidato GetById(int id);
        IEnumerable<Candidato> GetAll();
        void Update(Candidato candidato);
        void Remove(Candidato candidato);
    }
}
