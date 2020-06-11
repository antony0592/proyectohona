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

            VoucherModel voucher = new VoucherModel(connectionString);
            IList<Voucher> listVoucher = voucher.GetAllVoucher();
            List<VoucherModel> voucherModel = new List<VoucherModel>();

            RoomModel room = new RoomModel(connectionString);
            IList<Room> listRoom = room.GetAllRoom();

            TypeRoomModel typeroom = new TypeRoomModel(connectionString);
            IList<TypeRoom> listTyperoom = typeroom.GetAllTypeRooms();
            List<TypeRoomModel> typeRoomModel = new List<TypeRoomModel>();
            for (int i = 0; i < listVoucher.Count; i++)
            {
                VoucherModel voucherNew = new VoucherModel();
                voucherNew.id = listVoucher[i].id;
                voucherNew.idpaymentcard = listVoucher[i].idpaymentcard;
                voucherNew.idreservation = listVoucher[i].idreservation;
                voucherNew.creationdate = listVoucher[i].creationdate;
                voucherModel.Add(voucherNew);
                for (int j = 0; j < reservation.Count; j++)
                {
                    if (listVoucher[i].idreservation.Equals(reservation[j].id))
                    {
                        ReservationModel reservationNew = new ReservationModel();
                        reservationNew.id = reservation[j].id;
                        reservationNew.idroom = reservation[j].idroom;
                        reservationNew.idclient = reservation[j].idclient;
                        reservationNew.arrivaldate = reservation[j].arrivaldate;
                        reservationNew.departuredate = reservation[j].departuredate;
                        reservationModel.Add(reservationNew);

                        for (int k = 0; k < listclient.Count; k++)
                        {
                            if (reservation[j].idclient.Equals(listclient[k].id))
                            {
                                ClientModel clientNew = new ClientModel();
                                clientNew.id = listclient[k].id;
                                clientNew.name = listclient[k].name;
                                clientNew.lastname = listclient[k].lastname;
                                clientNew.email = listclient[k].email;
                                clientModel.Add(clientNew);
                            }
                        }
                        for (int k = 0; k < listRoom.Count; k++)
                        {
                            if (reservation[j].idroom.Equals(listRoom[k].id))
                            {
                                for (int f = 0; f < listTyperoom.Count; f++)
                                {
                                    if (listRoom[k].idtyperoom.Equals(listTyperoom[f].id))
                                    {
                                        TypeRoomModel typeRoomNew = new TypeRoomModel();
                                        typeRoomNew.description = listTyperoom[f].description;
                                        typeRoomModel.Add(typeRoomNew);
                                    }
                                }
                            }
                        }
                    }                                    
                }
                for (int k = 0; k < listPaymentcard.Count; k++)
                {
                    if (listPaymentcard[k].id.Equals(listVoucher[i].idpaymentcard))
                    {
                        PaymentcardModel paymentcardNew = new PaymentcardModel();
                        paymentcardNew.cardnumber = listPaymentcard[k].cardnumber;
                        paymentcardModel.Add(paymentcardNew);
                    }

                }


            }
            ViewBag.paymentcard = paymentcardModel;
            ViewBag.voucher = voucherModel;
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