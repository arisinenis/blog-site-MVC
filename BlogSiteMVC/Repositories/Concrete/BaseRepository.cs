using BlogSiteMVC.Models;
using BlogSiteMVC.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Repositories.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        private readonly AppDbContext db;
        public BaseRepository(AppDbContext db)
        {
            this.db = db;
        }

        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().FirstOrDefault(b => b.Id == id);
        }

        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
