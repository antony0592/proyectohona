using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using System;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorModifyPageController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public AdministratorModifyPageController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        // GET: /<controller>/
        [Authorize]
        public IActionResult ModifyPage()
        {
            return View();
        }

        [Authorize]
        public IActionResult ModifyHome()
        {
            HotelModel hotelModel = new HotelModel(connectionString);
            Hotel hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.id = hotels.id;
            hotel.name = hotels.name;
            hotel.description = hotels.description;            

            ContentPageModel contentpageModel = new ContentPageModel(connectionString);
            IList<ContentPage> content = contentpageModel.GetAllContentPage();
            List<ContentPageModel> contentPage = new List<ContentPageModel>();
            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].referentpage.Equals("home"))
                {
                    ContentPageModel contentNew = new ContentPageModel();
                    contentNew.urlimage = content[i].urlimage;
                    contentPage.Add(contentNew);
                }
            }
            ViewBag.contentPage = contentPage;
            ViewBag.hotel = hotel;
            return View();
        }

        [Authorize]
        public IActionResult ModifyAbout()
        {
            HotelModel hotelModel = new HotelModel(connectionString);
            Hotel hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.id = hotels.id;
            hotel.aboutus = hotels.aboutus;

            ViewBag.hotel = hotel;
            return View();
        }

        [Authorize]
        public IActionResult ModifyFacilities()
        {
            return View();
        }


        [Authorize]
        public IActionResult ModifyLocate()
        {
            HotelModel hotelModel = new HotelModel(connectionString);
            Hotel hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.id = hotels.id;
            hotel.address = hotels.address;
            ViewBag.hotel = hotel;
            return View();
        }

        [HttpPost]
        public ActionResult UpdateHome(string file, string description)
        {
            string destinationFile = "/images/" + file;
            Console.WriteLine(destinationFile);
            String urlimage = "/images/" + file;

            HotelModel hotelModel = new HotelModel(connectionString);

            ContentPageModel contentpageModel = new ContentPageModel(connectionString);
            IList<ContentPage> content = contentpageModel.GetAllContentPage();

            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].referentpage.Equals("home"))
                {
                    if (file == null || file == "")
                    {
                        urlimage = content[i].urlimage;
                    }
                    ContentPageModel contentPageNew = new ContentPageModel(connectionString);
                    contentPageNew.urlimage = content[i].urlimage;
                    contentpageModel=contentPageNew;
                }
            }
            hotelModel.UpdateHome(description);
            contentpageModel.UpdateContentPageHotel(urlimage, "home");
            return View("ModifyPage", "ModifyPage");
        }


        [HttpPost]
        public ActionResult UpdateAboutUs(string aboutus)
        {
            HotelModel hotelModel = new HotelModel(connectionString);

            hotelModel.UpdateAboutUs(aboutus);
            return View("ModifyPage", "ModifyPage");
        }
        
        [HttpPost]
        public ActionResult UpdateLocate(string address)
        {
            HotelModel hotelModel = new HotelModel(connectionString);

            hotelModel.UpdateLocate(address);
            return View("ModifyPage", "ModifyPage");
        }
    }

}