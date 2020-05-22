using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class RepositoryRoom
    {
        RoomBusiness roomBusiness;

        public RepositoryRoom(string connectionString)
        {
            this.roomBusiness = new RoomBusiness(connectionString);
        }

        public List<Room> GetAllRoom()
        {
            return roomBusiness.GetAllRoom();
        }

       


    }
}
