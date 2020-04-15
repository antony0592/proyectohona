using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Domain;

namespace Data
{
    public class ClientData
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public List<Client> GetAllClient()
        {
            List<Client> clients = new List<Client>();

            using (SqlConnection connection = new SqlConnection(connectionString))
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
