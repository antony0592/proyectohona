using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;



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
            //ViewBag.Mensaje=hotels[0].address.ToString();

            //RepositoryHotel hotelModel = new RepositoryHotel(connectionString);
            //IList<Hotel> hotels = hotelModel.GetAllHotel();
            //List<HotelModel> hotel = new List<HotelModel>();

            //for (int i = 0; i<hotels.Count; i++)
            //{
            //    HotelModel hotelNew = new HotelModel();
            //    hotelNew.name = hotels[0].name;
            //    hotelNew.description = hotels[0].description;
            //    hotelNew.aboutus= hotels[0].aboutus;
            //    hotelNew.address = hotels[0].address;
            //    hotelNew.pobox = hotels[0].pobox;
            //    hotelNew.email = hotels[0].email;
            //    hotel.Add(hotelNew);
            //}
            return View(hotel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
