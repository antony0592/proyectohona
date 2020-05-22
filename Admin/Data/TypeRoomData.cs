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

        public List<TypeRoom> Getroom(string description)
        {

            List<TypeRoom> typeRoom = new List<TypeRoom>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectTypeRoomUpdate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    typeRoom.Add(new TypeRoom
                    {
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        urlimage = sqlDataReader["urlimage"].ToString(),
                        descriptiontyperoom = sqlDataReader["descriptiontyperoom"].ToString()

                    });
                }
                connection.Close();
            }
            return typeRoom;
        }



    }
}
