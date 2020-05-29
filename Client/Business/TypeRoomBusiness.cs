using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Data;

namespace Business
{
    public class TypeRoomBusiness
    {
        private TypeRoomData typeRoomData;

        public TypeRoomBusiness(String connString)
        {
            this.typeRoomData = new TypeRoomData(connString);
        }//Fin del constructor.


        public List<TypeRoom> GetAllTypeRoom()
        {
            return this.typeRoomData.GetAllTypeRoom();
        }

        public TypeRoom GetTypeRoomByIdRoom(int id)
        {
            return typeRoomData.GetTypeRoomByIdRoom(id);
        }
    }
}

