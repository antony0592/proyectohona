using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorAvailabilityController : Controller
    {

        private readonly IConfiguration _configuration;
        string connectionString = "";

        TypeRoomModel typeRoomModal;

        public AdministratorAvailabilityController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            typeRoomModal = new TypeRoomModel(connectionString);
        }

        // GET: /<controller>/
        [Authorize]
        public IActionResult Availability()
        {
            ViewBag.TypeRoom = typeRoomModal.GetAllTypeRooms();
            return View();
        }

        public JsonResult SearchRoomAvailability(string date1,string date2,int typeRoom) 
        {
            return Json("");
        }
    }
}
