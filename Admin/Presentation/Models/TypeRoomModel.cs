using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class TypeRoomModel
    {
        public int id { get; set; }
        public int quantityperson { get; set; }
        public int quantitybed { get; set; }
        public String description { get; set; }
        public int amount { get; set; }
        public String urlimage { get; set; }
        public String descriptiontyperoom { get; set; }


        TypeRoomBusiness typeRoomBusiness;
        public TypeRoomModel(string connectionString)
        {
            this.typeRoomBusiness = new TypeRoomBusiness(connectionString);
        }
        public TypeRoomModel()
        {            
        }
        public List<TypeRoom> GetAllTypeRooms()
        {
            return typeRoomBusiness.GetAllTypeRoom();
        }


    }//class
}