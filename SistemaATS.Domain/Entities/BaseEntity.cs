using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaATS.Domain.Entities
{
    public abstract class BaseEntity<TEntity>
    {
        protected BaseEntity(TEntity Id = default)
        {
            Id = id;
        }

        public virtual TEntity id { get; }
    }
}
