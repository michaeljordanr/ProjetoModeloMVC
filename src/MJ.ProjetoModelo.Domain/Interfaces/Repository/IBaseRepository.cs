using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MJ.ProjetoModelo.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity ObterPorId(Guid id);
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);

    }
}
 