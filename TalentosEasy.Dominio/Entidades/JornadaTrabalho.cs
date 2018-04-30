using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentosEasy.Dominio.Entidades
{
    public class JornadaTrabalho
    {
        public int Id { get; set; }

        public int CandidatoId { get; set; }

        public virtual Candidato Candidato { get; set; }

        public bool HorasAteQuatro { get; set; }

        public bool HorasQuatroASeis { get; set; }

        public bool HorasSeisAOito { get; set; }

        public bool HorasAcimaDeOito { get; set; }

        public bool HorasFimDeSemana { get; set; }

        public bool PeriodoManha { get; set; }

        public bool PeriodoTarde { get; set; }

        public bool PeriodoNoite { get; set; }

        public bool PeriodoMadrugada { get; set; }

        public bool PeriodoComercial { get; set; }

        public bool DisponibilidadeUrgencia { get; set; }

        public int PretensaoSalarialHora { get; set; }
    }
}
