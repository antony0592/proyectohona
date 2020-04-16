using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Domain;

namespace Data
{
    public class HotelData
    {
        private String connString;

        public HotelData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public List<Hotel> GetAllHotel()
        {

            List<Hotel> hotels = new List<Hotel>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectHotel", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    hotels.Add(new Hotel
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        name = sqlDataReader["name"].ToString(),
                        description = sqlDataReader["description"].ToString(),
                        aboutus = sqlDataReader["aboutus"].ToString(),
                        address = sqlDataReader["address"].ToString(),
                        pobox = sqlDataReader["pobox"].ToString(),
                        email = sqlDataReader["email"].ToString()
                    });
                }
                connection.Close();
            }
            return hotels;
        }
    }
}

