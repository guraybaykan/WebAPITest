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
        private IUserRepository _userRepository;

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
        public ILanguageRepository Languages
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
        public IBookRepository Books
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
        public IPublisherRepository Publishers
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

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_bookAdviserContext);
                }
                return _userRepository;
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
