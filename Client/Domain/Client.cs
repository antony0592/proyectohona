using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Client
    {
        public Client()
        {
        }

        public Client(int id, decimal identification, string name, string lastname, string email)
        {
            this.id = id;
            this.identification = identification;
            this.name = name;
            this.lastname = lastname;
            this.email = email;
        }

        public int id { get; set; }
        public decimal identification { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
    }
}
