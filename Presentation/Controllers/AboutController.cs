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
            RepositorioHotel hotelModel = new RepositorioHotel(connectionString);
            IList<Hotel> hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.aboutus = hotels[0].aboutus;
            
            return View(hotel);
        }
    }
}