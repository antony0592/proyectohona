using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Domain;

namespace Data
{
    public class TypeRoomData
    {
        private String connString;

        public TypeRoomData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        
       public List<TypeRoom> GetAllTypeRoom()
        {

            List<TypeRoom> typeRoom = new List<TypeRoom>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectTypeRoom", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    typeRoom.Add(new TypeRoom
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        quantityperson = Convert.ToInt32(sqlDataReader["quantityperson"]),
                        quantitybed = Convert.ToInt32(sqlDataReader["quantitybed"]),
                        description = sqlDataReader["description"].ToString(),
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        urlimage = sqlDataReader["urlimage"].ToString(),
                        descriptiontyperoom = sqlDataReader["descriptiontyperoom"].ToString()

                    });
                }
                connection.Close();
            }
            return typeRoom;
        }

        public TypeRoom GetTypeRoomByIdRoom(int id)
        {
            SqlConnection connection = new SqlConnection(this.connString);
            String sqlSelect = "GetTypeRoomByIdRoom";
            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;
            sqlDataAdapterClient.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapterClient.SelectCommand.Parameters.Add(new SqlParameter("@id", id));

            DataSet dataSetTypeRooms = new DataSet();
            sqlDataAdapterClient.Fill(dataSetTypeRooms, "TypeRoom");
            sqlDataAdapterClient.SelectCommand.Connection.Close();
            DataRowCollection dataRowCollection = dataSetTypeRooms.Tables["TypeRoom"].Rows;
            TypeRoom typeRoom = new TypeRoom();

            foreach (DataRow currentRow in dataRowCollection)
            {
                typeRoom.id = Int32.Parse((currentRow["id"]).ToString());
                typeRoom.quantityperson = Int32.Parse(currentRow["quantityperson"].ToString());
                typeRoom.quantitybed = Int32.Parse(currentRow["quantitybed"].ToString());
                typeRoom.description = currentRow["description"].ToString();
                typeRoom.amount = Convert.ToInt32(currentRow["amount"]);
                typeRoom.urlimage = currentRow["urlimage"].ToString();
                typeRoom.descriptiontyperoom = currentRow["descriptiontyperoom"].ToString();
            }//Fin del foreach.
            List<Season> season = new List<Season>();

            using (SqlConnection connection1 = new SqlConnection(connString))
            {
                connection1.Open();
                SqlCommand command = new SqlCommand("[SelectSeasonClient]", connection1);
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
                connection1.Close();
            }

            TypeRoom typeRoom1 = new TypeRoom();

            for (int i = 0; i < season.Count; i++)
            {

          if (season[i].idtyperoom == typeRoom.id)
               {
                    typeRoom1=(new TypeRoom(typeRoom.id, typeRoom.quantityperson, typeRoom.quantitybed, typeRoom.description, typeRoom.amount + season[i].percentation, typeRoom.urlimage, typeRoom.descriptiontyperoom));

                }//if

        }//for i

            return typeRoom1;
        }//fin
    }
}
