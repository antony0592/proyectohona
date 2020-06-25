using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorModifyPageController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment environment;
        string connectionString = "";

        public AdministratorModifyPageController(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            this.environment = environment;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        
        [Authorize]
        public IActionResult ModifyPage()
        {
            return View();
        }

        //Home
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
        
        [HttpPost]
        public ActionResult UpdateHome(string description, IFormFile file)
        {
            HotelModel hotelModel = new HotelModel(connectionString);

            if (description != null)
            {
                hotelModel.UpdateHome(description);
            }

            ContentPageModel contentpageModel = new ContentPageModel(connectionString);
            IList<ContentPage> content = contentpageModel.GetAllContentPage();

            string urlimage = "";
            var path = "./images/";
            var pathClient = "../../../Client/Presentation/wwwroot/images/";
            string folderFiles = Path.Combine(environment.WebRootPath, path);
            string folderFilesClient = Path.Combine(environment.WebRootPath, pathClient);

            if (file != null)
            {
                contentpageModel.SaveImage(file, folderFiles);
                contentpageModel.SaveImage(file, folderFilesClient);
                urlimage = "/images/" + file.FileName;
            }

            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].referentpage.Equals("home"))
                {
                    if (file == null)
                    {
                        urlimage = content[i].urlimage;
                    }
                    ContentPageModel contentPageNew = new ContentPageModel(connectionString);
                    contentPageNew.urlimage = content[i].urlimage;
                    contentpageModel = contentPageNew;
                }
            }
            contentpageModel.UpdateContentPageHotel(urlimage, "home");
            return View("ModifyPage", "ModifyPage");
        }

        //About us
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
        [HttpPost]
        public ActionResult UpdateAboutUs(string aboutus)
        {
            HotelModel hotelModel = new HotelModel(connectionString);

            hotelModel.UpdateAboutUs(aboutus);
            return View("ModifyPage", "ModifyPage");
        }

        //Facilities
        [Authorize]
        public IActionResult ModifyFacilities()
        {
            return View();
        }

        //Locate
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
        public ActionResult UpdateLocate(string address)
        {
            HotelModel hotelModel = new HotelModel(connectionString);

            hotelModel.UpdateLocate(address);
            return View("ModifyPage", "ModifyPage");
        }
    }

}