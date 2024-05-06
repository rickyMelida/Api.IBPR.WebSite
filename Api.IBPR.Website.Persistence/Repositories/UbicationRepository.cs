using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class UbicationRepository : IUbication
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public UbicationRepository(AppDbContext context, IUnitOfWork unitOfWork) => 
            (_context, _unitOfWork) = (context, unitOfWork);
        
        public async Task<Ubication> GetUbication(int id)
        {
            return await _context.Ubication.FirstAsync(t => t.Id == id);
        }

        public async Task<List<Ubication>> GetUbications()
        {
            return await _context.Ubication.ToListAsync();
        }

        public async Task<Ubication> SetUbication(Ubication ubication)
        {
            await _context.Ubication.AddAsync(ubication);
            await _unitOfWork.Save();

            return ubication;
        }

        public async Task<Ubication> UpdateUbication(int id, Ubication ubicationModified)
        {
            var ubication = await GetUbication(id);

            if(ubication == null)
                return null;

            ubication.Site = ubicationModified.Site;
            ubication.Direction = ubicationModified.Direction;

            await _unitOfWork.Save();

            return ubication;
        }
    }
}