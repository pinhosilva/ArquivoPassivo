using GAP_Arquivamento.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP_Arquivamento.Infra.Dados.EntidadesConfig
{
    public class PastaConfig : EntityTypeConfiguration<Pasta>
    {
        public PastaConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Mae)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Nascimento)
                .IsRequired();

            HasRequired(p => p.Arquivo)
                .WithMany()
                .HasForeignKey(p => p.ArquivoId);
        }
    }
}
