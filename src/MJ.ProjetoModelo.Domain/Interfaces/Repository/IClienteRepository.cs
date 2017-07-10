using MJ.ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ.ProjetoModelo.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        IEnumerable<Cliente> ObterAtivos();
    }
}
