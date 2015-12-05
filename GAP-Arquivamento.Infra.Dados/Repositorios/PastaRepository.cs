using GAP_Arquivamento.Dominio.Entidades;
using GAP_Arquivamento.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP_Arquivamento.Infra.Dados.Repositorios
{
    public class PastaRepository : RepositoryBase<Pasta>, IPastaRepository
    {
        public IEnumerable<Pasta> BuscarPorNome(string nome)
        {
            return Db.Pastas.Where(p => p.Nome == nome);
        }
    }
}
