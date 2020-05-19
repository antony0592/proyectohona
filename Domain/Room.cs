using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Room
    {
        public Room()
        {
        }

        public Room(int id, int idtyperoom, int state, int number, string typeroom, int quantityperson, int quantitybed, int amount, string urlimage, string descriptiontyperoom)
        {
            this.id = id;
            this.idtyperoom = idtyperoom;
            this.typeroom = typeroom;
            this.state = state;
            this.number = number;
            this.quantityperson = quantityperson;
            this.quantitybed = quantitybed;
            this.amount = amount;
            this.urlimage = urlimage;
            this.descriptiontyperoom = descriptiontyperoom;
        }

        public int id { get; set; }
        public int idtyperoom { get; set; }
        public string typeroom { get; set; }
        public int state { get; set; }
        public int number { get; set; }
        public int quantityperson { get; set; }
        public int quantitybed { get; set; }
        public int amount { get; set; }
        public string urlimage { get; set; }
        public string descriptiontyperoom { get; set; }
    }            
}
