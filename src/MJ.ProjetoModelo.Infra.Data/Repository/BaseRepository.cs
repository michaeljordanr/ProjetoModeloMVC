using MJ.ProjetoModelo.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MJ.ProjetoModelo.Infra.Data.Context;
using System.Data.Entity;

namespace MJ.ProjetoModelo.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected ProjetoContext Context;
        protected DbSet<TEntity> DbSet;
        public BaseRepository()
        {
            Context = new ProjetoContext();
            DbSet = Context.Set<TEntity>();
        }

        public void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
            Context.SaveChanges();
        }

        public void Atualizar(TEntity obj)
        {
            var entry = Context.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Excluir(TEntity obj)
        {
            DbSet.Remove(obj);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }
    }
}
