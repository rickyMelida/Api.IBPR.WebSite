using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Domain.Exceptions;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class TagRepository : ITag
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public TagRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);

        public async Task<bool> DeleteTag(int id)
        {
            var tagToDelete = await _context.Tag.SingleOrDefaultAsync(e => e.Id == id);

            if (tagToDelete == null)
                return false;

            _context.Tag.Remove(tagToDelete);
            await _unitOfWork.Save();

            return false;
        }

        public async Task<Tag> GetTag(int id)
        {
            var tag = await _context.Tag.SingleOrDefaultAsync(x => x.Id == id);

            if (tag == null)
                throw new TagException();

            return tag;
        }

        public async Task<List<Tag>> GetTags()
        {
            var tags = await _context.Tag.ToListAsync();
            
            if(tags == null)
                throw new TagException("No existe aun ningun Tag Creado");
            
            return tags;
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

        public async Task<Tag> UpdateTag(int id, Tag tagModified)
        {
            var tagToModified = await _context.Tag.SingleOrDefaultAsync(e => e.Id == id);

            if (tagToModified == null)
                throw new TagException();

            tagToModified.Name = tagModified.Name;
            await _unitOfWork.Save();

            return tagModified;
        }
    }
}
