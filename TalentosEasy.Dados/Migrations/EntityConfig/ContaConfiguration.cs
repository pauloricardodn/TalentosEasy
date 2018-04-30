using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;

namespace TalentosEasy.Dados.Migrations.EntityConfig
{
    public class ContaConfiguration: EntityTypeConfiguration<Conta>
    {
        public ContaConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.BancoCodigo)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(c => c.Agencia)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(c => c.TipoConta)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(c => c.NumeroConta)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(c => c.CpfTitular)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            HasRequired(c => c.Candidato)
                .WithMany()
                .HasForeignKey(c => c.CandidatoId);
        }
    }
}
