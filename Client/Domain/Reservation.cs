using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Reservation
    {
        public int id { get; set; }
        public int idroom { get; set; }
        public int idClient { get; set; }
        public float amount { get; set; }
        public string arrivaldate { get; set; }
        public string departuredate { get; set; }
        public string creationdate { get; set; }
    }
}
