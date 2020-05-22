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

        public List<Room> GetAllRoom()
        {
            return this.roomData.GetAllRoom();
        }
              

       
    }
}
