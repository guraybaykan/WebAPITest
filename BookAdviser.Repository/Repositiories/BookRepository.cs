using BookAdviser.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    internal class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(DbContext context) :
            base(context)
        {

        }

        public Book Get(string ISBN)
        {
            return _dbSet.FirstOrDefault(x => x.ISBN == ISBN);
        }

        public IEnumerable<Book> GetLang(string Lang)
        {
            return _dbSet.Where(x => x.LanguageID == Lang);
        }
        public IEnumerable<Book> GetByPriceRange(decimal LowerPrice,decimal UpperPrice)
        {
            return _dbSet.Where(x => x.Price >= LowerPrice && x.Price <= UpperPrice);
        }
    }
}
