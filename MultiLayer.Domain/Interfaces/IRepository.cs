using System;
using System.Linq;
using System.Linq.Expressions;

namespace MultiLayer.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(T entity);

        /// <summary>
        /// Delete entity by Id
        /// </summary>        
        /// <param name="id">Identifier</param>
        void Delete(object id);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(T entity);

        /// <summary>
        /// Update entity
        /// </summary>        
        /// <param name="entity">Entity</param>
        void Update(T entity);

        /// <summary>
        /// Gets All Entities
        /// </summary>
        IQueryable<T> GetAll { get; }

        /// <summary>
        /// Gets All Entities with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        IQueryable<T> GetAllNoTracking { get; }

        /// <summary>
        /// Gets All Entities Including Eager Loaded Relations
        /// </summary>
        /// <param name="includedProperties">Included Relations</param>
        /// <returns>Entities with eager loaded selected relations</returns>
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includedProperties);

        /// <summary>
        /// Get all Entities Including Eager loaded Relations also nested relations.
        /// </summary>
        /// <param name="includedProperties">Comma seperated table (relation) names to include in result set.</param>
        /// <returns>Entities with Eager loaded selected relations</returns>
        IQueryable<T> GetAllIncluding(string includedProperties);

        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        T GetById(object id);
    }

}
