using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    class ReservationDomain
    {
        public int id { get; set; }
        public int idroom { get; set; }
        public int idclient { get; set; }
        public decimal amount { get; set; }
        public DateTime arrivaldate { get; set; }
        public DateTime departuredate { get; set; }
    }
}
