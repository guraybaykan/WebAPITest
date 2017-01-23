using BookAdviser.Model.DTO;
using BookAdviser.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services;

namespace BookAdviser.API.Controllers
{
    public class BookController : ApiController
    {
        BookService _bs;
        public BookController()
        {
            _bs = new BookService();
        }
        [WebMethod]
        public IEnumerable<BookDTO> Get()
        {
            return _bs.GetAll();
        }

        [WebMethod]
        public BookDTO Get(int id)
        {
            return _bs.Get(id);
        }
        [WebMethod]
        public IEnumerable<BookDTO> Get(decimal LowerPrice, decimal UpperPrice )
        {
            return _bs.GetByPriceRange(LowerPrice, UpperPrice);
        }
        [WebMethod]
        public void Delete(int id)
        {
            _bs.Delete(id);
            
        }
    }
}
