using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery_Image.Data.Model;
using Image_Gallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Image_Gallery.Controllers
{
    public class ImageGalleryController : Controller
    {
        private readonly IImage ImageService;
        public ImageGalleryController(IImage _Imageservice)

        {
            ImageService = _Imageservice;

        }


        public IActionResult Index()
        {
            var ImageList = ImageService.GetAll();
            var model = new GalleryIndexModel()
            {
                Images = ImageList,
                searchquery = "'"

            };
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var image = ImageService.GetById(id);
            var model = new GalleryDetailModel()
            {
                Id = image.Id,
                Title = image.Title,
                Created = image.Created,
                Tags = image.Tags.Select(t => t.Description).ToList(),
                URL = image.URL

            };
            return View(model);
        }
    }
}