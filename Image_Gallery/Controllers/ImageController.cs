using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Image_Gallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Image_Gallery.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Upload()
        {
            var model = new ImageUploadModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult UploadNewImage()
        {
            return Ok();
        }
    }
}