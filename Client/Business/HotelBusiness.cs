﻿using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
