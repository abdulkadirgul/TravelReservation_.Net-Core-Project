using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T item)
        {
            using var c = new Context();
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var db = new Context();
            return db.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();

        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var db = new Context();
            return db.Set<T>().Where(filter).ToList();
        }

        public void Insert(T item)
        {
            using var c = new Context();
            c.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            using var c = new Context();
            c.Update(item);

        }
    }
}
