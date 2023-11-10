using Api.IBPR.Website.Core.Domain.Entities;

namespace Api.IBPR.Website.Core.Application.Repositories
{
    public interface IComment
    {
        Task<Comment> GetComment (int Id);
        Task<List<Comment>> GetCommentsByArticleId(int Id);
        Task<Comment> SetComment (Comment comment);
        Task DeleteComment (Comment comment);
        Task UpdateComment (Comment comment);
    }
}