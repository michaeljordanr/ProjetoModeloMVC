using MJ.ProjetoModelo.Domain.Entities;
using MJ.ProjetoModelo.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ.ProjetoModelo.Infra.Data.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> ObterAtivos()
        {
            return Find(c => c.Ativo); 
        }
    }
}
