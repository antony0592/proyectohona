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
            TypeRoomModel typeRoomModel = new TypeRoomModel(connectionString);

            ViewBag.TypeRoom = typeRoomModel.GetAllTypeRoom();
            return View();
        }

        public ActionResult Data(int amountsumit, string roomsumit, string roomdescriptionsumit, string urlimagesumit)
        {
            //acase optiene el costo de la reserva y se guarda para ser usada en la vista
            var montoTotal = amountsumit;
            var typeroom = roomsumit;

            ViewBag.ReservationCost = montoTotal;
            ViewBag.ReservationTypeRoom = typeroom;
            ViewBag.Reservationroomdescription = roomdescriptionsumit;
            ViewBag.Reservationurlimage = urlimagesumit;
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

        public JsonResult Getsearchroom(string date1, string date2, int typeroom)
        {
            RoomModel RoomModel = new RoomModel(connectionString);
            var search = RoomModel.Getsearchroom(date1, date2, typeroom);
            return Json(search);
        }
    }
}