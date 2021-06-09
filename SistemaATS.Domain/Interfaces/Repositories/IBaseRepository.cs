using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaATS.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        TEntity GetById(Expression<Func<TEntity, bool>> where);
        IEnumerable<TEntity> GetAll(); 
        void Add(TEntity obj);
        void Add(IEnumerable<TEntity> obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
        int Commit();
    }
}
