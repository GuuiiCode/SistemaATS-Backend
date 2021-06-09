namespace SistemaATS.Domain.Entities
{
    public abstract class BaseEntity<TEntity>
    {
        protected BaseEntity(TEntity Id = default)
        {
            Id = id;
        }

        public virtual TEntity id { get; set; }
    }
}
