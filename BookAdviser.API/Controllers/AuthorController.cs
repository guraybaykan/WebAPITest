using BookAdviser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookAdviser.API.Controllers
{
    public class AuthorController : ApiController
    {
        //AuthorRepository _repo = new AuthorRepository();
        public IEnumerable<Author> Get()
        {
            BookAdviserUnitOfWork work = new BookAdviserUnitOfWork();
            return work.Authors.GetAll();
        }

        //public void Put(Author author)
        //{
        //    _repo.Save(author);
        //}
    }
}
