using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IUbication
    {
        Task<List<Ubication>> GetUbications();
        Task<Ubication> GetUbication(int id);
        Task<Ubication> SetUbication(Ubication ubication);
        Task<Ubication> UpdateUbication(int id, Ubication ubicationModified);
    }
}