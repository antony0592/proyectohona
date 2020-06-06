using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Domain;

namespace Data
{
    public class ContentPageData
    {
        private String connString;

        public ContentPageData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public List<ContentPage> GetAllContentPage()
        {

            List<ContentPage> contentPage = new List<ContentPage>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectContentPage", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    contentPage.Add(new ContentPage
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        referentpage = sqlDataReader["referentpage"].ToString(),
                        urlimage = sqlDataReader["urlimage"].ToString(),
                        typeimage = sqlDataReader["typeimage"].ToString(),
                        content = sqlDataReader["content"].ToString(),
                        
                    });
                }
                connection.Close();
            }
            return contentPage;
        }

        
        public void UpdateContentPageHotel(string urlimage, string referentpage )
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "UpdateContentPageHotel";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@urlimage", urlimage));
            cmdInsertar.Parameters.Add(new SqlParameter("@referentpage", referentpage));
            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
        }

        //PUBLICITY
        public int AddPublicity(ContentPage contentPage)
        {
            return 0;
        }

        public int UpdatePublicity(ContentPage contentPage)
        {
            return 0;
        }
        public int DeletePublicity(int id)
        {
            return 0;
        }

    }
}

