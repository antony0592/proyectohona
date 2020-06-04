using System;
using Data;
using Domain;

namespace Business
{
    public class HotelBusiness
    {
        private HotelData hotelData;

        public HotelBusiness(String connString)
        {
            this.hotelData = new HotelData(connString);
        }//Fin del constructor.

        public Hotel GetAllHotel()
        {
            return this.hotelData.GetAllHotel();
        }

        public void UpdateHome(string description)
        {
            this.hotelData.UpdateHome(description);
        }

        public void UpdateAboutUs(string aboutus)
        {
            this.hotelData.UpdateAboutUs(aboutus);
        }

    }
}
