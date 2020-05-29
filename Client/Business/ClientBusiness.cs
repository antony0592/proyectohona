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

        public Client GetClientById(int id)
        {
            return this.clientData.GetAllClients().Find(c=>c.id.Equals(id));
        }

        public Client GetClientByidentification(int identification)
        {
            return this.clientData.GetAllClients().Find(c => c.identification.Equals(identification));
        }
        public Client AddClient(Client client)
        {
            return this.clientData.AddClient(client);
        }
        

    }
}
