using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Presentation.Models
{
    public class RoomModel : Room
    {

        RoomBusiness roomBusiness;
        public RoomModel(string connectionString)
        {
            this.roomBusiness = new RoomBusiness(connectionString);
        }

        public RoomModel()
        {

        }
        public List<Room> GetAllRoom()
        {
            return this.roomBusiness.GetAllRoom();
        }


    }
}