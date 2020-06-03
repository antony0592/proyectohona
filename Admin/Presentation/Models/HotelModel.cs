using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class HotelModel
    {

        HotelBusiness hotelBusiness;
        public HotelModel(string connectionString)
        {
            this.hotelBusiness = new HotelBusiness(connectionString);
        }

        public HotelModel()
        {
            
        }



    }//class
}//
