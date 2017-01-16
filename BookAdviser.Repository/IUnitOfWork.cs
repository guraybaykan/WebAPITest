using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
    }
}
