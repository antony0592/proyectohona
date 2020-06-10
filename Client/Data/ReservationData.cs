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


        public Reservation AddReservation(Reservation reservation)
        {

            Reservation resultReservation = new Reservation();

            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "AddReservation";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();

            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlStoredProcedure;
            sqlDataAdapterClient.SelectCommand.Connection = connection;
            sqlDataAdapterClient.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@idroom", reservation.idroom));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@idclient", reservation.idClient));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@amount", reservation.amount));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@arrivaldate", DateTime.Parse(reservation.arrivaldate)));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@departuredate", DateTime.Parse(reservation.departuredate)));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@creationdate", DateTime.Parse(reservation.creationdate)));

            DataSet dataSet = new DataSet();
            sqlDataAdapterClient.Fill(dataSet, "tbreservation");
            sqlDataAdapterClient.SelectCommand.Connection.Close();
            DataRowCollection dataRowCollection = dataSet.Tables["tbreservation"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                resultReservation.id = Int32.Parse(currentRow["id"].ToString());
                resultReservation.idroom = Int32.Parse(currentRow["idroom"].ToString());
                resultReservation.idClient = Int32.Parse(currentRow["idclient"].ToString());
                resultReservation.amount = Int32.Parse(currentRow["amount"].ToString());
                resultReservation.arrivaldate = currentRow["arrivaldate"].ToString();
                resultReservation.departuredate = currentRow["departuredate"].ToString();
                resultReservation.creationdate = currentRow["creationdate"].ToString();
            }//Fin del foreach.

            return resultReservation;
        }


    }
}
