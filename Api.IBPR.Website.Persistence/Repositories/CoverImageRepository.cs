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

        public async Task<Image> SetCoverImage(Image coverImage)
        {
            await _context.Image.AddAsync(coverImage);
            await _unitOfWork.Save();

            return coverImage;
        }
    }
}