using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public class LanguageRepository : BaseRepository<Language>
    {
        public LanguageRepository(DbContext context) :
            base(context)
        {

        }
    }
}