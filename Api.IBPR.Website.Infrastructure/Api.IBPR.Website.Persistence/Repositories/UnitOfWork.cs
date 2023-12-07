using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Infrastructure.Persistence.Context;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OracleDbContext Context;

        public UnitOfWork(OracleDbContext context) =>
            Context = context;
        

        public async Task Save()
        {
            Context.SaveChangesAsync();
        }
    }
}
