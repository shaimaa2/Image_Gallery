using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery_Image.Data.Model
{
     public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        GalleryImage GetById(int id);
        IEnumerable<GalleryImage> GetWithTags(String Tag);
    }
}
