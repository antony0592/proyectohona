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

        public Room(int id, int idtyperoom, int state, int number)
        {
            this.id = id;
            this.idtyperoom = idtyperoom;
            this.state = state;
            this.number = number;
        }

        public int id { get; set; }
        public int idtyperoom { get; set; }
        public int state { get; set; }
        public int number { get; set; }
    }
}
