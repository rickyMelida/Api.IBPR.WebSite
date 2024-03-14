using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Entities;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class CoverImageRepository : ICoverImage
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public CoverImageRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);

        public async Task<IEnumerable<Image>> GetCoverImage(int id)
        {
            var result = await (from a in _context.Image
                                join b in _context.CoverImage
                                on a.Id equals b.Id
                                where a.Id == id
                                select new Image
                                {
                                    Id = a.Id,
                                    Name = a.Name,
                                    Picture = a.Picture
                                }).ToListAsync();

            return result;
        }

        public Task<CoverImages> SetCoverImage(CoverImages coverImage)
        {
            throw new NotImplementedException();
        }
    }
}