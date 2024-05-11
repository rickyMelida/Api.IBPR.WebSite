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

        public async Task<List<CoverImages>> GetCoverImage()
        {
            return await _context.CoverImage.ToListAsync();
        }

        public async Task<int> GetLastIdCoverImage()
        {
            var lasCoverImage = await _context.CoverImage.OrderByDescending(a => a.Id).FirstOrDefaultAsync();

            if(lasCoverImage == null)
                return 0;

            return lasCoverImage.Id; 
        }

        public async Task<CoverImages> SetCoverImage(CoverImages coverImage)
        {
            await _context.CoverImage.AddAsync(coverImage);
            await _unitOfWork.Save();

            return coverImage;
        }

        
    }
}