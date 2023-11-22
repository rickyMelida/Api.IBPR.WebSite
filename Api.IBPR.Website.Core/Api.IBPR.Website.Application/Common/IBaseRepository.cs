using Api.IBPR.Website.Core.Domain.Common;

namespace Api.IBPR.Website.Core.Application.Common
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(int id);
        Task<List<T>> GetAll();

    }
}