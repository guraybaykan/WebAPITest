using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        IQueryable<T> GetAll();
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);

    }
}
