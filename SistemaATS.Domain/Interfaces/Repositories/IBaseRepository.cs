using System.Collections.Generic;

namespace SistemaATS.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(); 
        void Add(TEntity obj);
        void Add(IEnumerable<TEntity> obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
