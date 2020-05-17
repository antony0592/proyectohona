using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class TypeRoom
    {
        public TypeRoom()
        {
        }

        public TypeRoom(int id, int quantityperson, int quantitybed, string description, int amount, string urlimage, string descriptiontyperoom)
        {
            this.id = id;
            this.quantityperson = quantityperson;
            this.quantitybed = quantitybed;
            this.description = description;
            this.amount = amount;
            this.urlimage = urlimage;
            this.descriptiontyperoom = descriptiontyperoom;
        }

        public int id { get; set; }
        public int quantityperson { get; set; }
        public int quantitybed { get; set; }
        public String description { get; set; }
        public int amount { get; set; }
        public String urlimage { get; set; }
        public String descriptiontyperoom { get; set; }
    }

}
