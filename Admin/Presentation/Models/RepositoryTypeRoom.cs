using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Presentation.Models
{
    public class RepositoryTypeRoom
    {
        TypeRoomBusiness typeRoomBusiness;
        public RepositoryTypeRoom(string connectionString)
        {
            this.typeRoomBusiness = new TypeRoomBusiness(connectionString);
        }

        public List<TypeRoom> GetAllTypeRoom()
        {
            return typeRoomBusiness.GetAllTypeRoom();
        }

        public List<TypeRoom> Getroom(string description)
        {
            return typeRoomBusiness.Getroom(description);
        }
    }
}