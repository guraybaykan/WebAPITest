using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User Login(string name, string password);
    }
}
