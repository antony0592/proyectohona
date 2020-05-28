using Business;
using Domain;
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

        public IList<SearchAvailabilityResult> Getsearchroom(string date1, string date2, int typeroom)
        {
            return administratorAvailabilityBusiness.Getsearchroom(date1, date2, typeroom);
        }
    }
}
