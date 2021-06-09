using Microsoft.EntityFrameworkCore;
using SistemaATS.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
            try
            {
                return Context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Add(TEntity obj)
        {
            try
            {
                Set.Add(obj);
                Commit();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Add(IEnumerable<TEntity> obj)
        {
            try
            {
                Set.AddRange(obj);
                Commit();
            }
            catch (Exception)
            {
                throw;
            } 
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return Set.ToList();
            }
            catch (Exception)
            {
                throw;
            } 
        }

        public TEntity GetById(int id)
        {
            try
            {
                return Set.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                return Set.AsNoTracking().FirstOrDefault(where);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(TEntity obj)
        {
            try
            {
                Set.Remove(obj);
                Commit();
            }
            catch (Exception)
            {
                throw;
            } 
        }

        public void Update(TEntity obj)
        {
            try
            {
                Context.Entry(obj).State = EntityState.Modified;
                Commit(); 
            }
            catch (Exception)
            {
                throw;
            } 
        }

        public void Dispose()
        {
            try
            {
                if (Context != null)
                    Context.Dispose();

                GC.SuppressFinalize(this);
            }
            catch (Exception)
            {
                throw;
            } 
        } 

    }
}
