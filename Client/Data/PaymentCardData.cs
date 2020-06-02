using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class PaymentCardData
    {


        private String connString;

        public PaymentCardData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public int AddPaymentCard(PaymentCard paymentCardData)
        {

            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "AddPaymentCard";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@number", paymentCardData.Number));
            command.Parameters.Add(new SqlParameter("@idclient", paymentCardData.IdClient));
            command.Parameters.Add(new SqlParameter("@date",paymentCardData.Date));
            command.Parameters.Add(new SqlParameter("@cvv", paymentCardData.Cvv));
            command.Parameters.Add(new SqlParameter("@type", paymentCardData.Type));


            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }
    }
}
