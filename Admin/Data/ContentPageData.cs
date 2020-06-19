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
        public int UpdatePublicity(ContentPage contentPage)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "InsertUpdatePublicity";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", contentPage.id));
            command.Parameters.Add(new SqlParameter("@urlimage", contentPage.urlimage));
            command.Parameters.Add(new SqlParameter("@content", contentPage.content));
            command.Parameters.Add(new SqlParameter("@action", "Update"));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }
        public int AddPublicity(ContentPage contentPage)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "InsertUpdatePublicity";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", contentPage.id));
            command.Parameters.Add(new SqlParameter("@urlimage", contentPage.urlimage));
            command.Parameters.Add(new SqlParameter("@content", contentPage.content));
            command.Parameters.Add(new SqlParameter("@action", "Insert"));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }
        
        public int DeletePublicity(int id)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "DeletePublicity";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Id", id));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }


        //FACILITY
        public int UpdateFacility(ContentPage contentPage)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "InsertUpdateFacility";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", contentPage.id));
            command.Parameters.Add(new SqlParameter("@urlimage", contentPage.urlimage));
            command.Parameters.Add(new SqlParameter("@content", contentPage.content));
            command.Parameters.Add(new SqlParameter("@action", "Update"));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }
        public int AddFacility(ContentPage contentPage)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "InsertUpdateFacility";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", contentPage.id));
            command.Parameters.Add(new SqlParameter("@urlimage", contentPage.urlimage));
            command.Parameters.Add(new SqlParameter("@content", contentPage.content));
            command.Parameters.Add(new SqlParameter("@action", "Insert"));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        public int DeleteFacility(int id)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "DeleteFacility";
            SqlCommand command = new SqlCommand(sqlStoredProcedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Id", id));
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

    }
}

