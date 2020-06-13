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

            return typeRoom;
        }//
    }
}
