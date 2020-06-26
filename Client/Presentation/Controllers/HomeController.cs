using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using System.Web;



namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IActionResult Index()
        {


            /***********************UNO POR UNO****************/
            RepositoryHotel hotelModel = new RepositoryHotel(connectionString);
            Hotel hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.name = hotels.name;
            hotel.description = hotels.description;
            hotel.address = hotels.address;

            /***************************************************/
            RepositoryContentPage contentpageModel = new RepositoryContentPage(connectionString);
            IList<ContentPage> content = contentpageModel.GetAllContentPage();
            List<ContentPageModel> contentPage = new List<ContentPageModel>();


            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].referentpage.Equals("home"))
                {
                ContentPageModel contentNew = new ContentPageModel();
                contentNew.referentpage = content[i].referentpage;
                contentNew.urlimage = content[i].urlimage;
                contentNew.typeimage = content[i].typeimage;
                contentNew.content = content[i].content;
                contentPage.Add(contentNew);
                }
            }
            ViewBag.contentPage = contentPage;
            ViewBag.allContentPage = contentpageModel.GetAllContentPage();
            ViewBag.hotel = hotel;
            return View();
        }

        public JsonResult GetPublicity()
        {
            RepositoryContentPage contentpageModel = new RepositoryContentPage(connectionString);
            var publicityList = contentpageModel.GetAllContentPage().Where(p => p.referentpage.Equals("publicity"));
            return Json(publicityList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
