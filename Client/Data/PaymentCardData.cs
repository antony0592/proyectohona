using Domain;
using System;
using System.Collections.Generic;
using System.Data;
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

        public PaymentCard AddPaymentCard(PaymentCard paymentCard)
        {
            //valirdar null cardname
            if (paymentCard.cardname == null) 
            {
                return null;
            }
            PaymentCard resultPaymentCard = new PaymentCard();

            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "AddPaymentCard";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();

            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlStoredProcedure;
            sqlDataAdapterClient.SelectCommand.Connection = connection;
            sqlDataAdapterClient.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@cardname", paymentCard.cardname));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@cvv", paymentCard.cvv));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@cardtype", paymentCard.cardtype));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@cardnumber", paymentCard.cardnumber));
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@expirationdate", paymentCard.expirationdate));


            DataSet dataSetPaymentCards = new DataSet();
            sqlDataAdapterClient.Fill(dataSetPaymentCards, "PaymentCard");
            sqlDataAdapterClient.SelectCommand.Connection.Close();
            DataRowCollection dataRowCollection = dataSetPaymentCards.Tables["PaymentCard"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                resultPaymentCard.id = Int32.Parse((currentRow["id"]).ToString());
                resultPaymentCard.cardname = currentRow["cardname"].ToString();
                resultPaymentCard.cvv = currentRow["cvv"].ToString();
                resultPaymentCard.cardtype = currentRow["cardtype"].ToString();
                resultPaymentCard.cardnumber = currentRow["cardnumber"].ToString();
                resultPaymentCard.expirationdate = currentRow["expirationdate"].ToString();
            }//Fin del foreach.
            return resultPaymentCard;
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
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        cardname = sqlDataReader["cardname"].ToString(),
                        cardnumber = sqlDataReader["cardnumber"].ToString(),
                        cardtype = sqlDataReader["cardtype"].ToString(),
                        cvv = sqlDataReader["cvv"].ToString(),
                        expirationdate = sqlDataReader["expirationdate"].ToString()
                    }
                    );
                }
                connection.Close();
            }
            return paymentCards;
        }
        public int AddVoucher(int paymentId, int idreservation)
        {

            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "AddVoucher";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idpaymentcard", paymentId));
            command.Parameters.Add(new SqlParameter("@idreservation", idreservation));
            command.Parameters.Add(new SqlParameter("@creationdate", DateTime.Parse(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"))));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }
    }
}
