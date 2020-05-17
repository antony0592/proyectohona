using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class ClientData
    {
        private String connString;

        public ClientData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public List<Client> GetAllClients() 
        {

            List<Client> clients = new List<Client>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectClient", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    clients.Add(new Client
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        identification = Convert.ToDecimal(sqlDataReader["identification"]),
                        name = sqlDataReader["name"].ToString(),
                        lastname = sqlDataReader["lastname"].ToString(),
                        email = sqlDataReader["email"].ToString()
                    }
                    );
                }
                connection.Close();
            }
            return clients;
        }
    }
}
