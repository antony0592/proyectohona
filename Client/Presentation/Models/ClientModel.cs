﻿using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class ClientModel
    {
        ClientBusiness clientBusiness;
        public ClientModel(string connectionString)
        {
            this.clientBusiness = new ClientBusiness(connectionString);
        }

        public IList<Client> GetAllClients()
        {
            return clientBusiness.GetAllClients();
        }

        public Client GetClientById(int id)
        {
            return clientBusiness.GetClientById(id);
        }
        public Client GetClientByidentification(int identification)
        {
            return clientBusiness.GetClientByidentification(identification);
        }
        public Client AddClient(Client client)
        {
            return clientBusiness.AddClient(client);
        }
        

    }
}
