using Api.IBPR.Website.Core.Application.Repositories;
using Api.IBPR.Website.Core.Domain.Entities;
using Api.IBPR.Website.Infrastructure.Persistence.Context;

namespace Api.IBPR.Website.Infrastructure.Persistence.Repositories
{
    public class ValueRepository: IValues
    {
        private readonly OracleDbContext _dbcontext;

        public ValueRepository(OracleDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Create(Values entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Values entity)
        {
            throw new NotImplementedException();
        }

        public Task<Values> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Values>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Values entity)
        {
            throw new NotImplementedException();
        }
    }
}