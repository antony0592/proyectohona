using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using Domain;

using Microsoft.Extensions.Configuration;

namespace Presentation.Controllers
{
    public class AboutController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public AboutController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public ActionResult Home()
        {
            RepositoryContentPage contentpageModel = new RepositoryContentPage(connectionString);
            IList<ContentPage> content = contentpageModel.GetAllContentPage();
            List<ContentPageModel> contentPage = new List<ContentPageModel>();

            for (int i = 0; i < content.Count; i++)            {
                ContentPageModel contentNew = new ContentPageModel();
                contentNew.referentpage = content[i].referentpage;
                contentNew.urlimage = content[i].urlimage;
                contentNew.typeimage = content[i].typeimage;
                contentNew.content = content[i].content;
                contentPage.Add(contentNew);
            }

            RepositoryHotel hotelModel = new RepositoryHotel(connectionString);
            Hotel hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.aboutus = hotels.aboutus;

            ViewBag.contentPage = contentPage;
            ViewBag.hotel = hotel;
            return View();
        }


        
    }


}
