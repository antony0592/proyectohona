using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class SeasonData
    {
        private String connString;

        public SeasonData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public List<Season> GetAllSeason()
        {

            List<Season> season = new List<Season>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectSeason", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    season.Add(new Season
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idtyperoom = Convert.ToInt32(sqlDataReader["idtyperoom"]),
                        dateinputseason = sqlDataReader["dateinputseason"].ToString(),
                        dateoutputseason = sqlDataReader["dateoutputseason"].ToString(),
                        description = sqlDataReader["description"].ToString(),
                        state = Convert.ToInt32(sqlDataReader["state"]),
                        percentation = Convert.ToInt32(sqlDataReader["percentation"])

                    });
                }
                connection.Close();
            }
            return season;
        }//

        public void InsertSeason(int id, int idtyperoom, string dateinputseason, string dateoutputseason, string description, int state, int percentation)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "InsertSeason";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@id", id));
            cmdInsertar.Parameters.Add(new SqlParameter("@idtyperoom", idtyperoom));
            cmdInsertar.Parameters.Add(new SqlParameter("@dateinputseason", dateinputseason));
            cmdInsertar.Parameters.Add(new SqlParameter("@dateoutputseason", dateoutputseason));
            cmdInsertar.Parameters.Add(new SqlParameter("@description", description));
            cmdInsertar.Parameters.Add(new SqlParameter("@state", state));
            cmdInsertar.Parameters.Add(new SqlParameter("@percentation", percentation));
            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Parameters.Clear();

            cmdInsertar.Connection.Close();

        }

        public void DeleteSeason(int id)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlStoredProcedure = "DeleteSeason";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoredProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@id", id));
            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Parameters.Clear();

            cmdInsertar.Connection.Close();
        }
    }
}
