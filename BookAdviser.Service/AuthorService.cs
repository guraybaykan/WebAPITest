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
        public AuthorDTO Get(int id)
        {
            return _uow.Authors.Get(id).GetAuthorDTO();
        }

        public void Save(AuthorDTO author)
        {
            if(author.ID == 0)
            {
                _uow.Authors.Add(author.GetAuthor());
            }
            else
            {
                var record = _uow.Authors.Get(author.ID);
                record.Name = author.Name;
            }

            _uow.Complete();
        }

        public void Delete(int id)
        {
            _uow.Authors.Delete(id);
            _uow.Complete();
        }
     
    }
}
