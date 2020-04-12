using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;


namespace Presentation.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Datos()
        {
            return View();
        }

        public ActionResult Confirmacion()
        {
            return View();
        }

    }
}