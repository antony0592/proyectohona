using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Domain;

namespace Data
{
    public class VoucherData
    {
        private String connString;

        public VoucherData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.


        public List<Voucher> GetAllVoucher()
        {

            List<Voucher> voucher = new List<Voucher>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectVoucher", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    voucher.Add(new Voucher
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idpaymentcard = Convert.ToInt32(sqlDataReader["idpaymentcard"]),
                        idreservation= Convert.ToInt32(sqlDataReader["idreservation"]),
                        creationdate = Convert.ToDateTime(sqlDataReader["creationdate"])

                    });
                }
                connection.Close();
            }
            return voucher;
        }

        public int DeleteVoucherList(int idreservation)
        {
            int resultToReturn;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DeleteVoucher", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idreservation", idreservation);

                resultToReturn = command.ExecuteNonQuery();

                connection.Close();

            }
            return resultToReturn;
        }
    }
}
