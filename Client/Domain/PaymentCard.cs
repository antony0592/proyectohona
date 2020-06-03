using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PaymentCard
    {
        public int Id { get; set; }
        public long Number { get; set; }
        public int IdClient { get; set; }
        public string Date { get; set; }
        public int Cvv { get; set; }
        public string Type { get; set; }

}
}
