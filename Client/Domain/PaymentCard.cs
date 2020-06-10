using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PaymentCard
    {
        public int id { get; set; }
        public string cardname { get; set; }
        public string cvv { get; set; }
        public string cardtype { get; set; }
        public string cardnumber { get; set; }
        public string expirationdate { get; set; }
    }
}
