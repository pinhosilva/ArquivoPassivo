using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP_Arquivamento.Dominio.Entidades
{
    public class Pasta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Mae { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime DataDeCadastro { get; set; }

        public int ArquivoId { get; set; }
        public virtual Arquivo Arquivo { get; set; }
    }
}
