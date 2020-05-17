using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using Domain;


namespace Presentation.Controllers
{
    public class LocateController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public LocateController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        // GET: Locate us
        public ActionResult Home()
        {
            RepositoryHotel hotelModel = new RepositoryHotel(connectionString);
            Hotel hotels = hotelModel.GetAllHotel();
            HotelModel hotel = new HotelModel();
            hotel.address = hotels.address;

            ViewBag.hotel = hotel;
            return View();
        }
    }
}