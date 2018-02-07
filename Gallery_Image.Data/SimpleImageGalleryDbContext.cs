using Gallery_Image.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Gallery_Image.Data
{
    public class SimpleImageGalleryDbContext : DbContext
    {

        public SimpleImageGalleryDbContext(DbContextOptions options) : base(options)

        {
        }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }

}
