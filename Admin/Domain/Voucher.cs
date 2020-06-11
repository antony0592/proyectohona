using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Voucher
    {
        public Voucher()
        {
        }

        public Voucher(int id, int idpaymentcard, int idreservation, DateTime creationdate)
        {
            this.id = id;
            this.idpaymentcard = idpaymentcard;
            this.idreservation = idreservation;
            this.creationdate = creationdate;
        }

        public int id { get; set; }
        public int idpaymentcard { get; set; }
        public int idreservation { get; set; }
        public DateTime creationdate { get; set; }

    }
}
