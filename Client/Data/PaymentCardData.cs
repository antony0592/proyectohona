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

        public int AddPaymentCard(PaymentCard paymentCard)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "AddPaymentCard";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@number", paymentCard.Number));
            command.Parameters.Add(new SqlParameter("@idclient", paymentCard.IdClient));
            command.Parameters.Add(new SqlParameter("@date", paymentCard.Date));
            command.Parameters.Add(new SqlParameter("@cvv", paymentCard.Cvv));
            command.Parameters.Add(new SqlParameter("@type", paymentCard.Type));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        public List<PaymentCard> SelectPaymentcard()
        {
            List<PaymentCard> paymentCards = new List<PaymentCard>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectPaymentcard", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    paymentCards.Add(new PaymentCard
                    {
                        Id = Convert.ToInt32(sqlDataReader["id"]),
                        IdClient = Convert.ToInt32(sqlDataReader["idclient"]),
                        Cvv = Convert.ToInt32(sqlDataReader["cvv"]),
                        Type = sqlDataReader["type"].ToString(),
                        Number = Convert.ToInt64(sqlDataReader["number"]),
                        Date = sqlDataReader["date"].ToString()
                    }
                    );
                }
                connection.Close();
            }
            return paymentCards;
        }
    }
}
