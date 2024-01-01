using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Application.Repositories
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