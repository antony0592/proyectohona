using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Domain;

namespace Data
{
    public class ReservationData
    {
        private String connString;

        public ReservationData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.


        public List<Reservation> GetAllReservation()
        {
            List<Reservation> reservation = new List<Reservation>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectReservation", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    reservation.Add(new Reservation
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idroom = Convert.ToInt32(sqlDataReader["idroom"]),
                        idclient = Convert.ToInt32(sqlDataReader["idclient"]),
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        arrivaldate = Convert.ToDateTime(sqlDataReader["arrivaldate"]),
                        departuredate = Convert.ToDateTime(sqlDataReader["departuredate"])
                    });
                }
                connection.Close();
            }
            return reservation;
        }

        public List<Reservation> GetAllReservationToday()
        {
            List<Reservation> reservation = new List<Reservation>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectReservation_today", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    reservation.Add(new Reservation
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idroom = Convert.ToInt32(sqlDataReader["idroom"]),
                        idclient = Convert.ToInt32(sqlDataReader["idclient"]),
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        arrivaldate = Convert.ToDateTime(sqlDataReader["arrivaldate"]),
                        departuredate = Convert.ToDateTime(sqlDataReader["departuredate"])
                    });
                }
                connection.Close();
            }
            return reservation;
        }

    }
}
