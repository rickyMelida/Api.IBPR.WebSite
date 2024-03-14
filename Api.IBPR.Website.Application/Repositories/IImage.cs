using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IImage
    {
        Task<Image> Get(int id);
        Task<Image> Set(Image image);
        Task<Image> Update(Image image);
        Task<bool> Delete(int id);
    }
}