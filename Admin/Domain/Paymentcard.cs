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

        public Paymentcard(int id, int number, int idclient, DateTime date, int cvv, string type)
        {
            this.id = id;
            this.number = number;
            this.idclient = idclient;
            this.date = date;
            this.cvv = cvv;
            this.type = type;
        }

        public int id { get; set; }
        public int number { get; set; }
        public int idclient { get; set; }
        public DateTime date { get; set; }
        public int cvv { get; set; }
        public string type { get; set; }
        
    }
}
