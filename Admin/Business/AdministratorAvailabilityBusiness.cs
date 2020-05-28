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
    }
}
