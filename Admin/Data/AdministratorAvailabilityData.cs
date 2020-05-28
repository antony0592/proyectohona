using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using Domain;

namespace Data
{
    public class AdministratorAvailabilityData
    {

        private String connString;

        public AdministratorAvailabilityData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public List<SearchAvailabilityResult> GetsearchroomAvailability(string date1, string date2, int typeroomparameter)
        {
            List<SearchAvailabilityResult> room = new List<SearchAvailabilityResult>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SearchRoom", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@arrivaldate", SqlDbType.Date).Value = date1;
                command.Parameters.Add("@departuredate", SqlDbType.Date).Value = date2;
                command.Parameters.Add("@typeroom", SqlDbType.Int).Value = typeroomparameter;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    room.Add(new SearchAvailabilityResult
                    {
                        typeroom = sqlDataReader["typeroom"].ToString(),
                        number = Convert.ToInt32(sqlDataReader["number"]),
                        amount = Convert.ToInt32(sqlDataReader["amount"])
                    });
                }
                connection.Close();
            }
            return room;
        }
    }
}
