using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Image_Gallery.Models
{
    public class ImageUploadModel
    {
        public String  Title { get; set; }
        public String Tags { get; set; }
        public IFormFile Uploadfile { get; set; }
    }
}
