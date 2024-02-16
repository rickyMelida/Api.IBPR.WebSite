using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class VerseRepository : IVerse
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public VerseRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);
        

        public async Task<Verse> GetVerse(int id)
        {
            return await _context.Verse.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<Verse>> GetVerses()
        {
            return await _context.Verse.ToListAsync();
        }

        public async Task SetVerse(Verse verse)
        {
            await _context.Verse.AddAsync(verse);
        }
    }
}
