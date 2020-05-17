using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class RoleBusiness
    {
        private RoleData roleData;

        public RoleBusiness(String connString)
        {
            this.roleData = new RoleData(connString);
        }//Fin del constructor.

        public Boolean GetIsAuthenticatedByRole() 
        {
            List<UserDTO> users = roleData.GetUsersByRole("Admin");

            return true;

        }
    }
}
