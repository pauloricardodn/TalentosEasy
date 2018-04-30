using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;

namespace TalentosEasy.Dados.Migrations
{
    public class Configuration:DbMigrationsConfiguration<Contexto.TalentosEasyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(Contexto.TalentosEasyContext context)
        {
            var candidatos = new List<Candidato>
            {
            new Candidato{Nome = "Carson", Email = "lexander@gmail.com", Skype= "lexander10", Whatsapp = "35-999214375", Linkedin = "gsddgsdfgdgdf",
                Cidade = "Divisa Nova", Estado = "Minas Gerais", LinkCrud = "www.teste.com", PontosNegativos ="ter pouco conhecimento", PontosPositivos = "vontade aprender",
                Portfolio = "", DataCadastro =DateTime.Now}
            };

            candidatos.ForEach(s => context.Candidato.Add(s));
            context.SaveChanges();
        }
    }
}
