using Business;
using Domain;
using System;

namespace Presentation.Models
{
    public class HotelModel:Hotel
    {
        HotelBusiness hotelBusiness;

        public HotelModel(String connectionString)
        {
            this.hotelBusiness = new HotelBusiness(connectionString);
        }

        public HotelModel()
        {
            
        }   
        public Hotel GetAllHotel()
        {
            return hotelBusiness.GetAllHotel();
        }

        public void UpdateHome(string description)
        {
            this.hotelBusiness.UpdateHome(description);
        }

        public void UpdateAboutUs(string aboutus)
        {
            this.hotelBusiness.UpdateAboutUs(aboutus);
        }
                
        public void UpdateLocate(string address)
        {
            this.hotelBusiness.UpdateLocate(address);
        }
    }//class
}//
