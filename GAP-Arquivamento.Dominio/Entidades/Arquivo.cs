using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP_Arquivamento.Dominio.Entidades
{
    public class Arquivo
    {
        public int Id { get; set; }
        public string Letra { get; set; }
        public int Numero { get; set; }
        public DateTime DataDeCadastro { get; set; }

        public virtual IEnumerable<Pasta> Pastas { get; set; }
    }
}
