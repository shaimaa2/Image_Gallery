using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery_Image.Data.Model
{
   public class GalleryImage
    {
        public int Id { get; set; }
        public String Title { get; set; }

        public DateTime Created { get; set; }

        public String URL { get; set; }
        public virtual IEnumerable<ImageTag> Tags { get; set; }

    }
}
