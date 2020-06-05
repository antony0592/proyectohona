using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class ReservationData
    {

        private String connString;

        public ReservationData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.


        public int AddReservation(Reservation reservation)
        {

            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "AddReservation";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idroom", reservation.idroom));
            command.Parameters.Add(new SqlParameter("@idclient", reservation.idClient));
            command.Parameters.Add(new SqlParameter("@amount", reservation.amount));
            command.Parameters.Add(new SqlParameter("@arrivaldate", DateTime.Parse(reservation.arrivaldate)));
            command.Parameters.Add(new SqlParameter("@departuredate", DateTime.Parse(reservation.departuredate)));
            command.Parameters.Add(new SqlParameter("@creationdate", DateTime.Parse(reservation.creationdate)));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

     
    }
}
