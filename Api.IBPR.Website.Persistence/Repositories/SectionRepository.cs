using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class SectionRepository: ISection
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public SectionRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);
        
        public async Task<List<Sections>> GetSections()
        {
            return await _context.Section.ToListAsync();
        }

        public async Task<Sections> GetSection(int id)
        {
            
            return await _context.Section.FirstAsync(x => x.Id == id);
        }

        public async Task SetSection(Sections section)
        {
            await _context.Section.AddAsync(section);   
        }

        public async Task UpdateSection(int id, Sections sectionModified)
        {
            var section = await GetSection(id);

            section.Id = sectionModified.Id;
            section.Section = sectionModified.Section;

            await _unitOfWork.Save();
        }

        public async Task DeleteSection(int id)
        {
            var section = await _context.Section.FirstAsync(x => x.Id == id);

            if(section != null)
            {
                _context.Remove(section);
                _context.SaveChanges();
            }    
        }

        public async Task<int> GetSectionId(string sectionName)
        {
            var sectionResult = await _context.Section.FirstAsync(x => x.Section == sectionName);
            
            if(sectionResult == null)
                return 0;

            return sectionResult.Id; 
        }
    }
}