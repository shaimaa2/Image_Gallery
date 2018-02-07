using Gallery_Image.Data.Model;
using Gallery_Image.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Image_Gallery.Services
{
    public class ImageService : IImage
    {
        private readonly SimpleImageGalleryDbContext ctx;
        public ImageService(SimpleImageGalleryDbContext cx)
        {
            ctx = cx;
        }
       public IEnumerable<GalleryImage> GetAll()
        {

            return ctx.GalleryImages.Include(img => img.Tags);
        }
        public GalleryImage GetById(int id)
        {
            return GetAll().Where(img => img.Id == id).First();
        }
        public IEnumerable<GalleryImage> GetWithTags(String Tag)
        {
          return  GetAll().Where(img => img.Tags.Any(T => T.Description == Tag));

        }
    }
}
