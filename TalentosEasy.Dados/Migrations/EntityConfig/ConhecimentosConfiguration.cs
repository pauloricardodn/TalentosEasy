using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;

namespace TalentosEasy.Dados.Migrations.EntityConfig
{
    public class ConhecimentosConfiguration: EntityTypeConfiguration<Conhecimentos>

    {
        public ConhecimentosConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Ionic)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Android)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Ios)
                    .IsRequired()
                    .HasColumnType("int"); 

            Property(c => c.Html)
                    .IsOptional()
                    .HasColumnType("int"); 

            Property(c => c.Css)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Bootstrap)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Jquery)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Angular)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Java)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.AspMVC)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.C)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Cplusplus)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Cake)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Django)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Magento)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Bootstrap)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Php)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Vue)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Wordpress)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Python)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Ruby)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.SqlServer)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.MySql)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Salesforce)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Photoshop)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Illustrator)
                    .IsOptional()
                    .HasColumnType("int");

            Property(c => c.Seo)
                    .IsRequired()
                    .HasColumnType("int");

            Property(c => c.Outros)
                    .IsOptional()
                    .HasColumnType("varchar")
                    .HasMaxLength(150);

            HasRequired(c => c.Candidato)
                .WithMany()
                .HasForeignKey(c => c.CandidatoId);
        }
    }
}
