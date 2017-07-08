using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Context;
using Core.DAL;

namespace Core.ORM
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private TheaterContext Context = new TheaterContext();

        public TEntity GetById(long id)
        {
            return Context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }

    }
}
