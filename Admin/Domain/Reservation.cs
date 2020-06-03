using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public Reservation(int id, int idroom, int idclient, int amount, DateTime arrivaldate, DateTime departuredate, DateTime creationdate)
        {
            this.id = id;
            this.idroom = idroom;
            this.idclient = idclient;
            this.amount = amount;
            this.arrivaldate = arrivaldate;
            this.departuredate = departuredate;
            this.creationdate = creationdate;
        }

        public int id { get; set; }
        public int idroom { get; set; }
        public int idclient { get; set; }
        public int amount { get; set; }
        public DateTime arrivaldate { get; set; }
        public DateTime departuredate { get; set; }
        public DateTime creationdate { get; set; }

    }
}