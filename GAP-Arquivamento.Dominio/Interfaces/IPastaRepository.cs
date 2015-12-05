using GAP_Arquivamento.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP_Arquivamento.Dominio.Interfaces
{
    public interface IPastaRepository : IRepositoryBase<Pasta>
    {
        IEnumerable<Pasta> BuscarPorNome(string nome);
    }
}
