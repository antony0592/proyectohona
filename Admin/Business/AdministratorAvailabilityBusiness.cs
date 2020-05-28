using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Domain;


namespace Business
{
    public class AdministratorAvailabilityBusiness
    {

        private AdministratorAvailabilityData administratorAvailabilityData;

        public AdministratorAvailabilityBusiness(String connString)
        {
            this.administratorAvailabilityData = new AdministratorAvailabilityData(connString);
        }//Fin del constructor.

        public List<SearchAvailabilityResult> Getsearchroom(string date1, string date2, int typeroom)
        {

            List<SearchAvailabilityResult> roomResult = new List<SearchAvailabilityResult>();
            roomResult = this.administratorAvailabilityData.GetsearchroomAvailability(date1, date2, typeroom);

            return roomResult;
           
        }
    }
}
