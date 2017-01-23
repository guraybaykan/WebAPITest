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
    public class AuthorController : ApiController
    {
        AuthorService _as;
        public AuthorController()
        {
            _as = new AuthorService();
        }
 

        [WebMethod]
        public IEnumerable<AuthorDTO> Get()
        {
           return _as.Get(); 
        }

        [WebMethod]
        public AuthorDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        [WebMethod]
        public void Post(AuthorDTO author)
        {
            _as.Save(author);
        }
        [WebMethod]
        public void Put(AuthorDTO id)
        {
            
        }

    }
}
