using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface ICoverImage
    {
        Task<IEnumerable<Image>> GetCoverImage(int id);
        Task<CoverImages> SetCoverImage(CoverImages coverImage);

    }
}