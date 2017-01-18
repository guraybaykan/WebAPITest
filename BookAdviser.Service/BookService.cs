using BookAdviser.Model.DTO;
using BookAdviser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Service
{
    public class BookService
    {
        BookAdviserUnitOfWork _uow;
        public BookService()
        {
            _uow = new BookAdviserUnitOfWork();
        }

        public IEnumerable<BookDTO> GetBookList()
        {
            return _uow.Books.GetAll().Select(x => new BookDTO{
                Name = x.Name,
                AuthorName = x.Author.Name,
                Publisher = x.Publisher.Name,
                Abstract = x.Abstract,
                Language = x.Language.Name,
                PublishYear = x.PublishYear,
                Price = x.Price,
                ISBN = x.ISBN,
                TranslatorName = x.Translator == null ? null : x.Translator.Name 
            });
        }
    }
}
