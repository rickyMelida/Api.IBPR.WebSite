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
        Task<List<Image>> GetImages();
        Task<Image> SetImage(Image image);
        Task<Image> Update(int id, Image imageModified);
        Task<bool> Delete(int id);
        Task<int> GetLastIdImage();
    }
}