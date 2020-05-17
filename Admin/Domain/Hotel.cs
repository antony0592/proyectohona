using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Hotel
    {
        public Hotel()
        {
        }

        public Hotel( string name, string description, string aboutus, string address, string pobox, string email)
        {
            this.name = name;
            this.description = description;
            this.aboutus = aboutus;
            this.address = address;
            this.pobox = pobox;
            this.email = email;
        }

        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String aboutus { get; set; }
        public String address { get; set; }
        public String pobox { get; set; }
        public String email { get; set; }


    }
}
