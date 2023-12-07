using Api.IBPR.Website.Core.Application.Repositories;
using Api.IBPR.Website.Core.Domain.Entities;
using Api.IBPR.Website.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Values>> GetAll()
        {
            return await _dbcontext.Values.ToListAsync();
        }

        public void Update(Values entity)
        {
            throw new NotImplementedException();
        }
    }
}