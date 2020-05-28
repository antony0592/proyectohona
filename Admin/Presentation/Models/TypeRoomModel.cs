using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class TypeRoomModel:TypeRoom
    {

        TypeRoomBusiness typeRoomBusiness;
        public TypeRoomModel(string connectionString)
        {
            this.typeRoomBusiness = new TypeRoomBusiness(connectionString);
        }
        public List<TypeRoom> GetAllTypeRooms()
        {
            return typeRoomBusiness.GetAllTypeRoom();
        }
    }
}