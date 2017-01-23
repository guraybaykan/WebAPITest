using BookAdviser.Model.DTO;
using BookAdviser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookAdviser.Service.DTOMapping;

namespace BookAdviser.Service
{
    public class BookService
    {
        BookAdviserUnitOfWork _uow;
        public BookService()
        {
            _uow = new BookAdviserUnitOfWork();
        }

        public IEnumerable<BookDTO> GetAll()
        {
            return _uow.Books.GetAll().Select(x => x.GetBookDTO());
        }
        public BookDTO Get(int id)
        {
            var book= _uow.Books.Get(id);
            var BDTO = book.GetBookDTO();
            return BDTO;
        }
        public IEnumerable<BookDTO> GetByPriceRange(decimal LowerPrice,decimal UpperPrice)
        {
            return _uow.Books.GetByPriceRange(LowerPrice, UpperPrice).Select(x=>x.GetBookDTO());
        }
        
        public void Delete(int id)
        {
            _uow.Books.Delete(id);
        }
    }
}
