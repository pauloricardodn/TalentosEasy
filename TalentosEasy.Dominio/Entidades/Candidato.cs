using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentosEasy.Dominio.Entidades
{
    public class Candidato
    {
        public int Id { get; set; }  
        
        public virtual Conhecimentos Conhecimentos { get; set; }

        public virtual Conta Conta { get; set; }
        
        public virtual JornadaTrabalho JornadaTrabalho { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Whatsapp { get; set; }

        public string Linkedin { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Portfolio { get; set; }        

        public string LinkCrud { get; set; }

        public string PontosPositivos { get; set; }

        public string PontosNegativos { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
