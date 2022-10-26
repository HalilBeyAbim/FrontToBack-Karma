using Karma_Web.Models;
using Karma_Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Karma_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>()
            {
                new Slider
                {
                    Id= 1,
                    MainTitle = "Frida Kahlo",
                    SubTitle = "A class",
                    ImageUrl ="usaq.jpg",
                },
                 new Slider
                {
                    Id= 2,
                    MainTitle = "Albert Einstein",
                    SubTitle = "A class",
                    ImageUrl ="usaq2.jpg",
                },
                  new Slider
                {
                    Id= 1,
                    MainTitle = "Edward Scissorhands",
                    SubTitle = "A class",
                    ImageUrl ="usaq3.jpg",
                }
            };
            List<Shoes> shoes = new List<Shoes>()
            {
                new Shoes
                {
                    Id = 1,
                    ImageUrl="bal1.jpg",
                },
                new Shoes
                {
                    Id = 2,
                    ImageUrl="bal2.webp",
                },
                new Shoes
                {
                    Id = 3,
                    ImageUrl="bal3.jpg",
                },
                new Shoes
                {
                    Id = 4,
                    ImageUrl="bal4.webp",
                },
                new Shoes
                {
                    Id = 5,
                    ImageUrl="bal5.jpg",
                },

            };

            HomeVM model = new HomeVM
            {
               Sliders = sliders,
               Shoes = shoes,
                
            };
            return View(model);
        }
       
    }
}
