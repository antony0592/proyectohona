﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    public class AdministratorPublicityController : Controller
    {
        // GET: /<controller>/
        [Authorize]
        public IActionResult Publicity()
        {
            return View();
        }

    }
}
