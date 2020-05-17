using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain;

namespace Presentation.Models
{
    public class RepositoryHotel
    {
        HotelBusiness hotelBusiness;
        public RepositoryHotel(string connectionString)
        {
            this.hotelBusiness = new HotelBusiness(connectionString);
        }

        public Hotel GetAllHotel()
        {
            return hotelBusiness.GetAllHotel();
        }

    }
}