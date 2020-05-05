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

        public ActionResult Data()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }   
    }
}