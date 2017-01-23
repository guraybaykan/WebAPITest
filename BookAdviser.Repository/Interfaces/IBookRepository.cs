using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        Book Get(string ISBN);
        IEnumerable<Book> GetLang(string Lang);
        IEnumerable<Book> GetByPriceRange(decimal LowerPrice, decimal UpperPrice);
    }
}
