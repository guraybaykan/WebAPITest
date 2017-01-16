using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        DbContext _context;
        DbSet<T> _dbSet;
        public BaseRepository() 
        {
            _context = new BookAdviserEntities();
            _dbSet = _context.Set<T>();
        }

        public virtual T Get(int id)
        {
            return _dbSet.Find(id);            
        }
        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.Where<T>(x => true);
        }
        public virtual void Save(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public virtual void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached) //Concurrency için
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public virtual void Delete(int id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
            _context.SaveChanges();
        }
    }
}
