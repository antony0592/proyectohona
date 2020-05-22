using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorModifyPageController : Controller
    {
        // GET: /<controller>/
        [Authorize]
        public IActionResult ModifyPage()
        {
            return View();
        }

        [Authorize]
        public IActionResult ModifyHome()
        {
            return View();
        }

        [Authorize]
        public IActionResult ModifyAbout()
        {
            return View();
        }

        [Authorize]
        public IActionResult ModifyFacilities()
        {
            return View();
        }


        [Authorize]
        public IActionResult Locate()
        {
            return View();
        }
    }
}
