using GAP_Arquivamento.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP_Arquivamento.Infra.Dados.EntidadesConfig
{
    public class ArquivoConfig : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Letra)
                .IsRequired()
                .HasMaxLength(1);

            Property(c => c.Numero)
                .IsRequired();
        }
    }
}
