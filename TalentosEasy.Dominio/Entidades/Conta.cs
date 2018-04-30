using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentosEasy.Dominio.Entidades
{
    public class Conta
    {
        public int Id { get; set; }

        public int CandidatoId { get; set; }

        public virtual Candidato Candidato { get; set; }

        public string BancoCodigo { get; set; }

        public string Agencia { get; set; }

        public string TipoConta { get; set; }

        public string NumeroConta { get; set; }

        public string CpfTitular { get; set; }

    }
}
