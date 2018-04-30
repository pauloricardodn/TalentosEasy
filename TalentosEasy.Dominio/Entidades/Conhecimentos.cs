﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentosEasy.Dominio.Entidades
{
    public class Conhecimentos
    {
        public int Id { get; set; }

        public int CandidatoId { get; set; }

        public virtual Candidato Candidato { get; set; }

        public int Ionic { get; set; }

        public int Android { get; set; }

        public int Ios { get; set; }

        public int? Html { get; set; }

        public int? Css { get; set; }

        public int Bootstrap { get; set; }

        public int Jquery { get; set; }

        public int Angular { get; set; }

        public int? Java { get; set; }

        public int AspMVC { get; set; }

        public int? C { get; set; }

        public int? Cplusplus { get; set; }

        public int? Cake { get; set; }

        public int? Django { get; set; }

        public int? Magento { get; set; }

        public int Php { get; set; }

        public int Vue { get; set; }

        public int Wordpress { get; set; }

        public int? Python { get; set; }

        public int? Ruby { get; set; }

        public int? SqlServer { get; set; }

        public int? MySql { get; set; }

        public int? Salesforce { get; set; }

        public int? Photoshop { get; set; }

        public int? Illustrator { get; set; }

        public int? Seo { get; set; }

        public string Outros { get; set; }
    }
}
