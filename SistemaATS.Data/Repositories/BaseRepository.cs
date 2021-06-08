using Microsoft.EntityFrameworkCore;
using SistemaATS.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaATS.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(DbContext context)
        {
            Context = context;
        }

        private DbContext Context { get; }

        private DbSet<TEntity> Set => Context.Set<TEntity>();

        public int Commit()
        {
            return Context.SaveChanges();
        }

        public void Add(TEntity obj)
        {
            Set.Add(obj);
            Commit();
        }

        public void Add(IEnumerable<TEntity> obj)
        {
            Set.AddRange(obj);
            Commit();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Set.ToList();
        }

        public TEntity GetById(int id)
        {
            return Set.Find(id);
        }

        public void Remove(TEntity obj)
        {
            Set.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
