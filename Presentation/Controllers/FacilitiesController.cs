﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;


namespace Presentation.Controllers
{
    public class FacilitiesController : Controller
    {
        // GET: Facilities
        public ActionResult Home()
        {
            return View();
        }
    }
}