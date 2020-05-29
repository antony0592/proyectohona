
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using System;

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


        public ActionResult Data(int id)
        {
            TypeRoomModel typeRoomModel = new TypeRoomModel(connectionString);
            TypeRoom typeroom = typeRoomModel.GetTypeRoomByIdRoom(id);
            ViewBag.TypeRoom = typeroom;
            return View();
        }

        public JsonResult GetRoomById(int id) 
        {

            return Json(id);
        }

        public ActionResult Confirmation(int identification,
                                            string name,
                                            string lastname,
                                            string email,
                                            int idroom,
                                            int amount,
                                            string arrivaldate,
                                            string departuredate)
        {

            ClientModel clientModel = new ClientModel(connectionString);
            ReservationModel reservationModel = new ReservationModel(connectionString);
            Client clientResult = clientModel.GetClientByidentification(identification);
            SendMail sendMail = null;

            if (clientResult == null)
            {
                Client newclient = new Client()
                {
                    id = 0,
                    identification = identification,
                    name = name,
                    lastname = lastname,
                    email = email

                };
                clientResult = clientModel.AddClient(newclient);
            }

            Reservation reservation = new Reservation()
            {
                id = 0,
                idroom = idroom,
                idClient = clientResult.id,
                amount = amount,
                arrivaldate = arrivaldate,
                departuredate = departuredate,
                creationdate = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")
            };
            var resultReservation = reservationModel.AddReservation(reservation);

            if (resultReservation > 0)
            {
                sendMail = new SendMail()
                {
                    email = clientResult.email,
                    name = clientResult.name,
                    lastname = clientResult.lastname,
                    identification = clientResult.identification,
                    action =    ".Su reserva ha sido exitosa, para el día "+reservation.arrivaldate +
                                " y hasta "+reservation.departuredate+
                                " por un monto total de " + reservation.amount +" dolares."
                 };

                sendMail.SendMailAction();
            }

            ViewBag.Reservation = reservation;
            ViewBag.Client = clientResult;
            ViewBag.Email = sendMail;

            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        public JsonResult GetClientById(int id)
        {
            ClientModel clientModel = new ClientModel(connectionString);
            var cliente = clientModel.GetClientByidentification(id);
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