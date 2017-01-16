using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        DbContext _context;
        DbSet<T> _dbSet;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual T Get(int id)
        {
            return _dbSet.Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.Where<T>(x => true);
        }
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Add(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }
        public virtual void Delete(int id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }
        public virtual void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached) //Concurrency için
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expr)
        {
            return _dbSet.Where<T>(expr);
        }
    }
}
