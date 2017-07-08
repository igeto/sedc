using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ORM
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Get element by id
        /// </summary>
        /// <param name="id">long integer id</param>
        /// <returns></returns>
        TEntity GetById(long id);

        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity">generic type entity</param>
        void Add(TEntity entity);

        /// <summary>
        /// Update new entity
        /// </summary>
        /// <param name="entity">generic type entity</param>
        void Update(TEntity entity);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">generic type entity</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Gets all enities from type
        /// </summary>
        /// <returns>IEnumerable<TEntity> entity</returns>
        IEnumerable<TEntity> GetAll();
    }
}
