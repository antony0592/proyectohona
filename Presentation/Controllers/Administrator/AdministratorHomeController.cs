using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    public class AdministratorHomeController : Controller
    {

        [Authorize]
        public IActionResult AdministratorIndex()
        {
            return View();
        }

        [Authorize]
        public IActionResult ModifyPage()
        {
            return View();
        }

        [Authorize]
        public IActionResult Availability()
        {
            return View();
        }

        [Authorize]
        public IActionResult ManageRooms()
        {
            return View();
        }

        [Authorize]
        public IActionResult Publicity()
        {
            return View();
        }

        [Authorize]
        public IActionResult ReservationList()
        {
            return View();
        }

        [Authorize]
        public IActionResult State()
        {
            return View();
        }


    }
}
