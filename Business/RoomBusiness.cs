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

        public List<Room> Getsearchroom()
        {
            return this.roomData.Getsearchroom();
        }

        public Room Getsearchroom(string date1, string date2, int typeroom)
        {
            /*LÓGICA*/

            return this.roomData.Getsearchroom().Find(c => c.id.Equals(typeroom));
        }
    }
}
