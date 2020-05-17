using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Data;

namespace Business
{
    public class RoomBusiness
    {
        private RoomData roomData;

        public RoomBusiness(String connString)
        {
            this.roomData = new RoomData(connString);
        }//Fin del constructor.

        public List<Room> Getsearchroom(int typeroom)
        {
            return this.roomData.Getsearchroom(typeroom);
        }

        public Room Getsearchroom(string date1, string date2, int typeroom)
        {
            /*LÓGICA*/

            return this.roomData.Getsearchroom(typeroom).Find(c => c.idtyperoom.Equals(typeroom));
        }
    }
}
