using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClientBusiness
    {
        ClientData clientData = new ClientData();
        public List<Client> GetAllClient()
        {
            return clientData.GetAllClient();
        }
    }
}