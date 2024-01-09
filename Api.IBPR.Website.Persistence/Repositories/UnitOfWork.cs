using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }


        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
