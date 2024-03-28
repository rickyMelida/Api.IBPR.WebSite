using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface ISection
    {
        Task<List<Sections>> GetSections();
        Task<Sections> GetSection(int id);
        Task SetSection(Sections section);
        Task UpdateSection(int id, Sections sectionModified);
        Task DeleteSection(int id);
    }
}