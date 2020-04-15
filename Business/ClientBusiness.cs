using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ClientBusiness
    {

        private ClientData clientData;

        public ClientBusiness(String connString)
        {
            this.clientData = new ClientData(connString);
        }//Fin del constructor.

        
        public List<Client> GetAllClients()
        {
            return this.clientData.GetAllClients();
        }
    }
}
