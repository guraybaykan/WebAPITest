using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public class PublisherRepository : BaseRepository<Publisher>
    {
        public PublisherRepository(DbContext context) :
            base(context)
        {

        }
    }
}

