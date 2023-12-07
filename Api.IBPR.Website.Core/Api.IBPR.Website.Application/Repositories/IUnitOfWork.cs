using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IUnitOfWork
    {
        Task Save();
    }
}
