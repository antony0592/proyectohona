using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Presentation.Models
{
    public class RoomModel
    {
        RoomBusiness roomBusiness;

        public RoomModel(string connectionString)
        {
            this.roomBusiness = new RoomBusiness(connectionString);
        }

        public IList<Room> GetRoom(string date1, string date2, int typeroom)
        {
            return roomBusiness.Getsearchroom(date1, date2, typeroom);
        }

        public IList<Room> Getsearchroom(string date1, string date2, int typeroom)
        {
            return roomBusiness.Getsearchroom2(date1, date2, typeroom);
        }


    }
}
