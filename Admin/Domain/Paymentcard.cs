using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Paymentcard
    {
        public Paymentcard()
        {
        }

        public Paymentcard(int id, long cardnumber, string expirationdate, int cvv, string cardtype)
        {
            this.id = id;
            this.cardnumber = cardnumber;
            this.expirationdate = expirationdate;
            this.cvv = cvv;
            this.cardtype = cardtype;
        }

        public int id { get; set; }
        public long cardnumber { get; set; }
        public string expirationdate { get; set; }
        public int cvv { get; set; }
        public string cardtype { get; set; }

    }
}
