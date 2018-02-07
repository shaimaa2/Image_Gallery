

using System;
using System.Collections.Generic;

namespace Image_Gallery.Models
{
    public class GalleryDetailModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String URL { get; set; }
        public List<String> Tags { get; set; }
        public DateTime Created { get; set; }
    }
}
