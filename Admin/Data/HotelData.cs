
using Domain;
using System;
using System.Data.SqlClient;

namespace Data
{
    public class HotelData
    {
        private String connString;

        public HotelData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public Hotel GetAllHotel()
        {
            Hotel hotel = new Hotel();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectHotel", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    hotel = new Hotel
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        name = sqlDataReader["name"].ToString(),
                        description = sqlDataReader["description"].ToString(),
                        aboutus = sqlDataReader["aboutus"].ToString(),
                        address = sqlDataReader["address"].ToString(),
                        pobox = sqlDataReader["pobox"].ToString(),
                        email = sqlDataReader["email"].ToString()
                    };
                }
                connection.Close();
            }
            return hotel;
        }

        
        public void UpdateHome(string description)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "UpdateHotel";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@description", description));            
            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();

            cmdInsertar.Connection.Close();
        }        

        public void UpdateAboutUs(string aboutus)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "UpdateAboutus";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@aboutus", aboutus));
            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();

            cmdInsertar.Connection.Close();
        }

        public void UpdateLocate(string address)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "UpdateLocate";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@address", address));
            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();

            cmdInsertar.Connection.Close();
        }
    }//class
}//namespace

