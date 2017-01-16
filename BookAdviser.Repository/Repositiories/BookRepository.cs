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
    }
}
