using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(int id);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IEnumerable<T> Find(Expression<Func<T, bool>> expr);

    }
}
