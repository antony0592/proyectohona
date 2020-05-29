using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ReservationBusiness
    {
        private ReservationData reservationData;

        public ReservationBusiness(String connString)
        {
            this.reservationData = new ReservationData(connString);
        }//Fin del constructor.

        public int AddReservation(Reservation reservation)
        {
            return this.reservationData.AddReservation(reservation);
        }

        
    }
}
