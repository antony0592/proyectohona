using Domain;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Client AddClient(Client client)
        {
            Client newClient = new Client();

            //SqlConnection connection = new SqlConnection(this.connString);
            //String sqlStoredProcedure = "AddClient";
            //SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            //command.Parameters.Add(new SqlParameter("@identification", client.identification));
            //command.Parameters.Add(new SqlParameter("@name", client.name));
            //command.Parameters.Add(new SqlParameter("@lastname", client.lastname));
            //command.Parameters.Add(new SqlParameter("@email", client.email));
            //command.Connection.Open();
            //int result = command.ExecuteNonQuery();
            //command.Connection.Close();

            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "AddClient";
            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;
            sqlDataAdapterClient.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@identification", client.identification));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@name", client.name));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@lastname", client.lastname));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@email", client.email));
            
            DataSet dataSetClientes = new DataSet();
            sqlDataAdapterClient.Fill(dataSetClientes, "ClientResult");
            sqlDataAdapterClient.SelectCommand.Connection.Close();
            DataRowCollection dataRowCollection = dataSetClientes.Tables["ClientResult"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                newClient.id = Int32.Parse((currentRow["id"]).ToString());
                newClient.identification = Int32.Parse(currentRow["identification"].ToString());
                newClient.name = currentRow["name"].ToString();
                newClient.lastname = currentRow["lastname"].ToString();
                newClient.email = currentRow["email"].ToString();
            }//Fin del foreach.

            return newClient;
        }

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
                        identification = Convert.ToInt32(sqlDataReader["identification"]),
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
