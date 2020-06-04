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
    public class AdministratorStateController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public AdministratorStateController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }
        // GET: /<controller>/
        [Authorize]
        public IActionResult State()
        {
            ReservationModel repositoryReservation = new ReservationModel(connectionString);
            IList<Reservation> reservation = repositoryReservation.GetAllReservation();
            List<ReservationModel> reservationModel = new List<ReservationModel>();

            List<ReservationModel> reservationModelfree = new List<ReservationModel>();


            RepositoryTypeRoom repositoryTyperoom = new RepositoryTypeRoom(connectionString);
            IList<TypeRoom> typeRoom = repositoryTyperoom.GetAllTypeRoom();
            List<TypeRoomModel> typeroomModel = new List<TypeRoomModel>();

            List<TypeRoomModel> typeroomModelfree = new List<TypeRoomModel>();


            RoomModel repositoryroom = new RoomModel(connectionString);
            IList<Room> room = repositoryroom.GetAllRoom();
            List<RoomModel> roomModel = new List<RoomModel>();

            List<RoomModel> roomModelfree = new List<RoomModel>();

            string date=DateTime.Now.ToString("yyyy-MM-dd");
            
            for (int i = 0; i < reservation.Count; i++)
                {
                    
                    ReservationModel reservationNew = new ReservationModel();
                    reservationNew.idroom = reservation[i].idroom;
                    reservationNew.arrivaldate = reservation[i].arrivaldate;
                   string strDate = reservation[i].arrivaldate.ToString("yyyy-MM-dd");

                for (int j = 0; j < room.Count; j++)
                    {
                        if (reservationNew.idroom.Equals(room[j].id) && strDate.Equals(date))
                        {
                            RoomModel RoomNew = new RoomModel(connectionString);
                            RoomNew.id = room[j].id;
                            RoomNew.number = room[j].number;
                            RoomNew.idtyperoom = room[j].idtyperoom;

                            for (int k = 0; k < typeRoom.Count; k++)
                            {
                                if (RoomNew.idtyperoom.Equals(typeRoom[k].id))
                                {
                                    TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                                    typeRoomNew.id = typeRoom[k].id;
                                    typeRoomNew.description = typeRoom[k].description;
                                    typeroomModel.Add(typeRoomNew);
                                    reservationModel.Add(reservationNew);
                                    roomModel.Add(RoomNew);
                                }
                            }//tercer for

                        }/// if reservation with Room

                    }//segundo for

                }//primer for

            for (int i = 0; i < reservation.Count; i++)
            {

                ReservationModel reservationNew = new ReservationModel();
                reservationNew.idroom = reservation[i].idroom;
                string strDate = reservation[i].arrivaldate.ToString("yyyy-MM-dd");

                for (int j = 0; j < room.Count; j++)
                {
                    if (reservationNew.idroom.Equals(room[j].id) && !strDate.Equals(date))
                    {
                        RoomModel RoomNew = new RoomModel(connectionString);
                        RoomNew.id = room[j].id;
                        RoomNew.number = room[j].number;
                        RoomNew.idtyperoom = room[j].idtyperoom;

                        for (int k = 0; k < typeRoom.Count; k++)
                        {
                            if (RoomNew.idtyperoom.Equals(typeRoom[k].id))
                            {
                                TypeRoomModel typeRoomNew = new TypeRoomModel(connectionString);
                                typeRoomNew.id = typeRoom[k].id;
                                typeRoomNew.description = typeRoom[k].description;
                                typeroomModelfree.Add(typeRoomNew);
                                reservationModelfree.Add(reservationNew);
                                roomModelfree.Add(RoomNew);
                            }
                        }//tercer for

                    }/// if reservation with Room

                }//segundo for

            }//primer for

            ViewBag.roomfree = roomModelfree;
            ViewBag.typeroomfree = typeroomModelfree;
            ViewBag.reservationfree = reservationModelfree;
            ViewBag.room = roomModel;
            ViewBag.typeroom = typeroomModel;
            ViewBag.reservation = reservationModel;

            return View();
           
        }//State

    }
}
