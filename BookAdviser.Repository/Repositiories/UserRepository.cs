using BookAdviser.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) :
            base(context)
        {

        }

        public User Login(string name, string password)
        {
             return _dbSet.FirstOrDefault(x => x.Name == name && x.Password == password);
        }

        
    }
}
