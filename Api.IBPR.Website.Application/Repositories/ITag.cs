using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface ITag
    {
        Task<Tag> GetTag (int Id);
        Task<List<Tag>> GetTags();
        Task<List<Tag>> GetTagsByIdArticle(int Id);
        Task<Tag> SetTag (Tag tag);
        Task DeleteTag (Tag tag);
        Task UpdateTag (Tag tag);
    }
}