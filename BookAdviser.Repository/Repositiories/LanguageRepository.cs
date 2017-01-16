using BookAdviser.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    internal class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(DbContext context) :
            base(context)
        {

        }
    }
}