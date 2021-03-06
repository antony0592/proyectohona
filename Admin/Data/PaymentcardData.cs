﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Domain;

namespace Data
{
    public class PaymentcardData
    {
        private String connString;

        public PaymentcardData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.


        public List<Paymentcard> GetAllPaymentcard()
        {
            List<Paymentcard> paymentcard = new List<Paymentcard>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectPaymentcard", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    paymentcard.Add(new Paymentcard
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        cardnumber = Convert.ToInt64(sqlDataReader["cardnumber"]),
                        expirationdate = sqlDataReader["expirationdate"].ToString(),
                        cvv = Convert.ToInt32(sqlDataReader["cvv"]),
                        cardtype = sqlDataReader["cardtype"].ToString()
                    });
                }
                connection.Close();
            }
            return paymentcard;
        }

    }
}
