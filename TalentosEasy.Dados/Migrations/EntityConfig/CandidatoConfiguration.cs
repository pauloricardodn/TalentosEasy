using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;

namespace TalentosEasy.Dados.Migrations.EntityConfig
{
    public class CandidatoConfiguration: EntityTypeConfiguration<Candidato>
    {
        public CandidatoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

            Property(c => c.Email)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

            Property(c => c.Skype)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(80);

            Property(c => c.Whatsapp)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(15);

            Property(c => c.Linkedin)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(150);

            Property(c => c.Cidade)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(80);

            Property(c => c.Estado)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(50);           

            Property(c => c.Portfolio)
                   .IsOptional()
                   .HasColumnType("varchar")
                   .HasMaxLength(150);

            Property(c => c.LinkCrud)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(150);

            Property(c => c.PontosPositivos)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(150);

            Property(c => c.PontosPositivos)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(150);

            Property(c => c.DataCadastro)
                   .IsRequired()
                   .HasColumnType("datetime");



        }        
    }
}
