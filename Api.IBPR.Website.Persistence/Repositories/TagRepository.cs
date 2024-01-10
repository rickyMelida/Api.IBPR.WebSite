using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class TagRepository : ITag
    {
        public Task DeleteTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> GetTag(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetTags()
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetTagsByIdArticle(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> SetTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTag(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
