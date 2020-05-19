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

        public List<Room> Getsearchroom(string date1, string date2, int typeroom)
        {
            return this.roomData.Getsearchroom1( date1,  date2, typeroom);
        }

        public List<Room> Getsearchroom2(string date1, string date2, int typeroom)
        {
            /*LÓGICA*/
           // this.roomData.DateFilter(date1, date2);

           List< Room> roomResult = new List< Room>();

            roomResult = this.roomData.Getsearchroom1(date1, date2, typeroom);
           
            if (roomResult.Count>0)
            {
                return roomResult;
            }
            else {
                return this.roomData.GetsearchroomRecomendation(date1, date2, typeroom);
            }
            
        }
    }
}
