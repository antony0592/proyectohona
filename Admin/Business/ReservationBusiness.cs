using System;
using System.Collections.Generic;
using Data;
using Domain;

namespace Business
{
    public class ReservationBusiness
    {

        private ReservationData reservationData;

        public ReservationBusiness(String connString)
        {
            this.reservationData = new ReservationData(connString);
        }//Fin del constructor.


        public List<Reservation> GetAllReservation()
        {
            return this.reservationData.GetAllReservation();
        }
    }
}
