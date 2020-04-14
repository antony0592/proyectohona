using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class ReservationData
    {
        public int id { get; set; }
        public int idroom { get; set; }
        public int idclient { get; set; }
        public decimal amount { get; set; }
        public DateTime arrivaldate { get; set; }
        public DateTime departuredate { get; set; }
    }
}
