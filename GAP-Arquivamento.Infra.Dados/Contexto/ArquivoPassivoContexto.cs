using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP_Arquivamento.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;
using GAP_Arquivamento.Infra.Dados.EntidadesConfig;

namespace GAP_Arquivamento.Infra.Dados.Contexto
{
    public class ArquivoPassivoContexto : DbContext
    {
        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<Pasta> Pastas { get; set; }

        public ArquivoPassivoContexto()
            : base("DBArquivoPassivoContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(150));

            modelBuilder.Configurations.Add(new ArquivoConfig());
            modelBuilder.Configurations.Add(new PastaConfig());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataDeCadastro").CurrentValue = DateTime.Now;
                if (entry.State == EntityState.Modified)
                    entry.Property("DataDeCadastro").IsModified = false;
            }
            return base.SaveChanges();
        }
    }
}
