using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class AdministratorAvailabilityModel
    {

        AdministratorAvailabilityBusiness administratorAvailabilityBusiness;

        public AdministratorAvailabilityModel(string connectionString)
        {
            this.administratorAvailabilityBusiness = new AdministratorAvailabilityBusiness(connectionString);
        }
    }
}
