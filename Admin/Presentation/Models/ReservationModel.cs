using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain;

namespace Presentation.Models
{
    public class ReservationModel : Reservation
    {
        ReservationBusiness reservationBusiness;
        public ReservationModel(string connectionString)
        {
            this.reservationBusiness = new ReservationBusiness(connectionString);
        }

        public ReservationModel()
        {

        }

        public List<Reservation> GetAllReservation()
        {
            return this.reservationBusiness.GetAllReservation();
        }

        public List<Reservation> GetAllReservationToday()
        {
            return this.reservationBusiness.GetAllReservationToday();
        }

        public void DeleteReservationList(int id)
        {
           this.reservationBusiness.DeleteReservationList(id);
        }

        

    }
}