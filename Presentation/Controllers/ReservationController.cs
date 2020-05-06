using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;


namespace Presentation.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public ReservationController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        // GET: Reservation
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Data()
        {
            //acase optiene el costo de la reserva y se guarda para ser usada en la vista
            ViewBag.ReservationCost = 5000;
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

        public JsonResult GetClientById(int id) 
        {
            ClientModel clientModel = new ClientModel(connectionString);
            var cliente = clientModel.GetClientById(id);
            return Json(cliente);
        }
    }
}