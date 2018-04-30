using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;

namespace TalentosEasy.Dados.Migrations.EntityConfig
{
    public class JornadaTrabalhoConfiguration: EntityTypeConfiguration<JornadaTrabalho>
    {
        public JornadaTrabalhoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.HorasAteQuatro)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.HorasQuatroASeis)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.HorasSeisAOito)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.HorasAcimaDeOito)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.HorasFimDeSemana)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.PeriodoManha)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.PeriodoTarde)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.PeriodoNoite)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.PeriodoMadrugada)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.PeriodoComercial)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.DisponibilidadeUrgencia)
                    .IsOptional()
                    .HasColumnType("bit");

            Property(c => c.PretensaoSalarialHora)
                    .IsRequired()
                    .HasColumnType("int");

            HasRequired(c => c.Candidato)
                .WithMany()
                .HasForeignKey(c => c.CandidatoId);
        }
    }
}
