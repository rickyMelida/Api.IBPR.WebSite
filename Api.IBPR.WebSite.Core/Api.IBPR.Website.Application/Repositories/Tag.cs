using Api.IBPR.Website.Core.Domain.Entities;

namespace Api.IBPR.Website.Core.Application.Repositories
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