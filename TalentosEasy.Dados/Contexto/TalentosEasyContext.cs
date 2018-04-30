using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;
using TalentosEasy.Dados.Migrations.EntityConfig;

namespace TalentosEasy.Dados.Contexto
{
    public class TalentosEasyContext : DbContext
    {
        public TalentosEasyContext()
            : base("TalentosEasy")
        {

        }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Conhecimentos> Conhecimento { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<JornadaTrabalho> JornadaTrabalho { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CandidatoConfiguration());
            modelBuilder.Configurations.Add(new ConhecimentosConfiguration());
            modelBuilder.Configurations.Add(new ContaConfiguration());
            modelBuilder.Configurations.Add(new JornadaTrabalhoConfiguration());
        }
    }
}
