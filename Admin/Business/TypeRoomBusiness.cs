using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Data;

namespace Business
{
    public class TypeRoomBusiness
    {
        private TypeRoomData typeRoom;

        public TypeRoomBusiness(String connString)
        {
            this.typeRoom = new TypeRoomData(connString);
        }//Fin del constructor.


        public List<TypeRoom> GetAllTypeRoom()
        {
            return this.typeRoom.GetAllTypeRoom();
        }

        public List<TypeRoom> Getroom(string description)
        {
            return this.typeRoom.Getroom(description);
        }

        public void UpdateTypeRoom(string description, string amount, string urlimage, int descriptionType)
        {
             this.typeRoom.UpdateTypeRoom(description, amount, urlimage, descriptionType);
        }


    }
}

