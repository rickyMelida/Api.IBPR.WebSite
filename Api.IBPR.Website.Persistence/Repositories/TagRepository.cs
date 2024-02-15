using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class TagRepository : ITag
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public TagRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);

        public Task DeleteTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> GetTag(int id)
        {
            return await _context.Tag.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Tag>> GetTags()
        {
            return await _context.Tag.ToListAsync();
        }

        public Task<List<Tag>> GetTagsByIdArticle(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SetTag(Tag tag)
        {
            await _context.Tag.AddAsync(tag);
            await _unitOfWork.Save();
        }

        public Task UpdateTag(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
