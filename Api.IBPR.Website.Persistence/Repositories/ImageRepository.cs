using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Domain.Common;
using Api.IBPR.Website.Domain.Exceptions;
using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.IBPR.Website.Persistence.Repositories
{
    public class ImageRepository : IImage
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ImageRepository(AppDbContext context, IUnitOfWork unitOfWork) =>
            (_context, _unitOfWork) = (context, unitOfWork);

        public async Task<Image> Get(int id)
        {
            var image = await _context.Image.SingleOrDefaultAsync(e => e.Id == id);

            if (image == null)
                throw new ImageException();

            return image;
        }

        public async Task<List<Image>> GetImages()
        {
            var images = await _context.Image.ToListAsync();

            if (images == null)
                throw new ImageException("No existe ninguna imagen aun en la Base de Datos");

            return images;
        }

        public async Task<Image> SetImage(Image image)
        {
            await _context.Image.AddAsync(image);
            await _unitOfWork.Save();

            return  await Get(image.Id);
        }

        public async Task<Image> Update(int id, Image imageModified)
        {
            var imageToModified = await _context.Image.SingleOrDefaultAsync(a => a.Id == id);

            if(imageToModified == null)
                throw new ImageException();

            imageToModified.Name = imageModified.Name;
            imageToModified.Picture = imageModified.Picture;

            await _unitOfWork.Save();

            return imageModified; 
        }
        public async Task<bool> Delete(int id)
        {
            var imageToDelete = await _context.Image.SingleOrDefaultAsync(a => a.Id == id);

            if(imageToDelete == null)
                return false;

            _context.Image.Remove(imageToDelete);
            await _unitOfWork.Save();

            return true;
        }

        public async Task<int> GetLastIdImage()
        {
            var lastImage = await _context.Image.OrderByDescending(a => a.Id).FirstOrDefaultAsync();

            if(lastImage == null)
                return 0;
            
            return lastImage.Id;
        }
    }
}