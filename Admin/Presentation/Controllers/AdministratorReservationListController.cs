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

            ClientModel client = new ClientModel(connectionString);
            IList<Client> listclient = client.GetAllClients();
            List<ClientModel> clientModel = new List<ClientModel>();

            PaymentcardModel paymentcard = new PaymentcardModel(connectionString);
            IList<Paymentcard> listPaymentcard = paymentcard.GetAllPaymentcard();
            List<PaymentcardModel> paymentcardModel = new List<PaymentcardModel>();

            RoomModel room = new RoomModel(connectionString);
            IList<Room> listRoom = room.GetAllRoom();

            TypeRoomModel typeroom = new TypeRoomModel(connectionString);
            IList<TypeRoom> listTyperoom = typeroom.GetAllTypeRooms();
            List<TypeRoomModel> typeRoomModel = new List<TypeRoomModel>();

            for (int i = 0; i < reservation.Count; i++)
            {
                ReservationModel reservationNew = new ReservationModel();
                reservationNew.id = reservation[i].id;
                reservationNew.idroom = reservation[i].idroom;
                reservationNew.idclient = reservation[i].idclient;
                reservationNew.arrivaldate = reservation[i].arrivaldate;
                reservationNew.departuredate = reservation[i].departuredate;
                reservationNew.creationdate = reservation[i].creationdate;
                reservationModel.Add(reservationNew);
                for (int j = 0; j < listclient.Count; j++)
                {
                    if (reservation[i].idclient.Equals(listclient[j].id))
                    {
                        ClientModel clientNew = new ClientModel();
                        clientNew.id = listclient[j].id;
                        clientNew.name = listclient[j].name;
                        clientNew.lastname = listclient[j].lastname;
                        clientNew.email = listclient[j].email;
                        clientModel.Add(clientNew);
                    }
                    
                }

                for (int j = 0; j < listRoom.Count; j++)
                {
                    if (reservation[i].idroom.Equals(listRoom[j].id))
                    {
                        for (int f = 0; f < listTyperoom.Count; f++)
                        {
                            if (listRoom[j].idtyperoom.Equals(listTyperoom[f].id))
                            {
                                TypeRoomModel typeRoomNew = new TypeRoomModel();
                                typeRoomNew.description = listTyperoom[f].description;
                                typeRoomModel.Add(typeRoomNew);
                            }
                        }
                    }
                }
                for (int k = 0; k < listPaymentcard.Count; k++)
                {
                    if (reservation[i].idclient.Equals(listPaymentcard[k].idclient) || clientModel[i].identification.Equals(listPaymentcard[k].idclient))
                    {
                        PaymentcardModel paymentcardNew = new PaymentcardModel();
                        paymentcardNew.number = listPaymentcard[k].number;
                        paymentcardModel.Add(paymentcardNew);
                    }

                }


            }
            ViewBag.paymentcard = paymentcardModel;
            ViewBag.reservation = reservationModel;
            ViewBag.typeroom = typeRoomModel;
            ViewBag.client = clientModel;
            return View();
        }

     
        public ActionResult DeleteReservationList(int id)
        {
            ReservationModel repositoryReservation = new ReservationModel(connectionString);
            Console.WriteLine(id);
            repositoryReservation.DeleteReservationList(id);
            return View();
        }
        
    }
}