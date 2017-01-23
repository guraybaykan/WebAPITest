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
    public class AuthorService
    {
        BookAdviserUnitOfWork _uow;
        public AuthorService()
        {
            _uow = new BookAdviserUnitOfWork();
        }
        public IEnumerable<AuthorDTO> Get()
        {
          return  _uow.Authors.GetAll().Select(x=>x.GetAuthorDTO());
        }

        public void Save(AuthorDTO author)
        {
            _uow.Authors.Add(author.GetAuthor());
            _uow.Complete();
        }
     
    }
}
