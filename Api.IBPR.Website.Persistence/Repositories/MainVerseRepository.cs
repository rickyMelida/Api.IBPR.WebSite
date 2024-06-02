using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class MainVerseRepository : IMainVerse
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public MainVerseRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);

        public async Task<List<MainVerse>> GetMainVerses()
        {
            return await _context.MainVerses.ToListAsync();
        }
        public async Task<MainVerse> GetMainVerse(int id)
        {
            return await _context.MainVerses.FindAsync(id);
        }

        public async Task<MainVerse> SetMainVerse(MainVerse mainVerse)
        {
            try
            {
                await _context.MainVerses.AddAsync(mainVerse);
                await _unitOfWork.Save();
                return mainVerse;
            }
            catch
            {
                return new MainVerse { };
            }

        }

        public async Task UpdateMainVerse(int id, MainVerse mainVerseUpdate)
        {
            try
            {
                MainVerse mainVerse = await _context.MainVerses.FindAsync(id);
                mainVerse.Section = mainVerseUpdate.Section;
                mainVerse.IdVerse = mainVerseUpdate.IdVerse;

                await _unitOfWork.Save();
            }
            catch
            {
                throw;
            }
        }
        public Task DeleteMainVerse(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetLastId()
        {
            var lastMainVerse = await _context.MainVerses.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
        
            if(lastMainVerse == null)
                return 0;

            return lastMainVerse.Id;
        }
    }
}