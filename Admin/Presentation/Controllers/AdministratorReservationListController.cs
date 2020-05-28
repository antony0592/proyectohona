using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;
using Domain;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers.Administrator
{
    [Authorize(Roles = "Admin")]
    public class AdministratorReservationListController : Controller
    {
        public static string counter;
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public AdministratorReservationListController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        // GET: /<controller>/
        [Authorize]
        public IActionResult ReservationList()
        {
            ReservationModel repositoryReservation = new ReservationModel(connectionString);
            IList<Reservation> reservation = repositoryReservation.GetAllReservation();
            List<ReservationModel> reservationModel = new List<ReservationModel>();


            for (int i = 0; i < reservation.Count; i++)
            {
                ReservationModel reservationNew = new ReservationModel();
                reservationNew.id = reservation[i].id;
                reservationNew.idroom = reservation[i].idroom;
                reservationNew.idclient = reservation[i].idclient;
                reservationNew.amount = reservation[i].amount;
                reservationNew.arrivaldate = reservation[i].arrivaldate;
                reservationNew.departuredate = reservation[i].departuredate;
                reservationModel.Add(reservationNew);
            }
            return View(reservationModel);
        }//
    }
}
