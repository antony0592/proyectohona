using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain;

namespace Presentation.Models
{
    public class RepositorioHotel
    {
        HotelBusiness hotelBusiness;
        public RepositorioHotel(string connectionString)
        {
            this.hotelBusiness = new HotelBusiness(connectionString);
        }

        public List<Hotel> GetAllHotel()
        {
            return hotelBusiness.GetAllHotel();
        }

    }
}