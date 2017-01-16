using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public class BookAdviserUnitOfWork :IUnitOfWork
    {
        private BookAdviserEntities _bookAdviserContext;

        #region Repositories
        private AuthorRepository _authorRepository;
        public AuthorRepository Authors
        {
            get
            {
                if(_authorRepository == null)
                {
                    _authorRepository = new AuthorRepository(_bookAdviserContext);
                }
                return _authorRepository;
            }
        }
        #endregion
        public BookAdviserUnitOfWork()
        {
            _bookAdviserContext = new BookAdviserEntities();
        }
        public void Complete()
        {
            _bookAdviserContext.SaveChanges();
        }

        public void Dispose()
        {
            _bookAdviserContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
