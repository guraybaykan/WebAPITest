using BookAdviser.Repository.Interfaces;
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
        private IAuthorRepository _authorRepository;
        private ILanguageRepository _languageRepository;
        private IBookRepository _bookRepository;
        private IPublisherRepository _publisherRepository; 

        public IAuthorRepository Authors
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
        public ILanguageRepository LanguageRepository
        {
            get
            {
                if(_languageRepository == null)
                {
                    _languageRepository = new LanguageRepository(_bookAdviserContext);
                }
                return _languageRepository;
            }
        }
        public IBookRepository BookRepository
        {
            get
            {
                if (_bookRepository == null)
                {
                    _bookRepository = new BookRepository(_bookAdviserContext);
                }
                return _bookRepository;
            }
        }
        public IPublisherRepository PublisherRepository
        {
            get
            {
                if (_publisherRepository == null)
                {
                    _publisherRepository = new PublisherRepository(_bookAdviserContext);
                }
                return _publisherRepository;
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
