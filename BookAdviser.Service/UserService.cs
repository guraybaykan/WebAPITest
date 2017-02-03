using BookAdviser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookAdviser.Service.DTOMapping;
using BookAdviser.Model.DTO;

namespace BookAdviser.Service
{
    public class UserService
    {
        BookAdviserUnitOfWork _uow;

        public UserService()
        {
            _uow = new BookAdviserUnitOfWork();
        }

        public UserDTO Login(string name, string password)
        {
            return _uow.Users.Login(name, password).GetUserDTO();
        }
    }
}
