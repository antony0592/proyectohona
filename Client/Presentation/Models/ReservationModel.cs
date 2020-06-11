using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class ReservationModel
    {
        ReservationBusiness reservationBusiness;
        public ReservationModel(string connectionString)
        {
            this.reservationBusiness = new ReservationBusiness(connectionString);
        }

        public Reservation AddReservation(Reservation reservation)
        {
            return reservationBusiness.AddReservation(reservation);
        }
    }
}
