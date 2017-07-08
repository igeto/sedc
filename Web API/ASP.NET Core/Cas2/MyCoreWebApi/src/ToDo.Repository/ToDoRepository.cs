using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Data;
using ToDo.Models;
using ToDo.Repository;

namespace ToDo.Repository
{
    public class ToDoRepository<T> : IRepository<T> where T : BaseEntity
    {
        private ToDoContext db { get; set; }
        public ToDoRepository(ToDoContext toDoContext)
        {
            db = toDoContext;
        }

        public bool Create(T item)
        {
            if (item == null || GetById(item.Id) != null) return false;
            db.Set<T>().Add(item);
            var rowsAffected = db.SaveChanges();
            return rowsAffected > 0;
        }

        public bool Delete(long id)
        {
            T itemToDelete = GetById(id);
            if (itemToDelete == null) return false;
            db.Set<T>().Remove(itemToDelete);
            var rowsAffected = db.SaveChanges();
            return rowsAffected > 0;
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(long id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public bool Update(T item)
        {
            if (item == null || GetById(item.Id) == null) return false;
            db.Set<T>().Update(item);
            var rowsAffected = db.SaveChanges();
            return rowsAffected > 0;
        }
    }
}
