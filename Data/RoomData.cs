using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Domain;

namespace Data
{
    public class RoomData
    {
        private String connString;

        public RoomData(String connString)
        {
            this.connString = connString;
        }//Fin del constructor.

        public List<Room> Getsearchroom(int typeroom)
        {
            List<Room> room = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SearchRoom", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@typeroom", SqlDbType.Int).Value = typeroom;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    room.Add(new Room
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idtyperoom = Convert.ToInt32(sqlDataReader["idtyperoom"]),
                        typeroom = sqlDataReader["typeroom"].ToString(),
                        state = Convert.ToInt32(sqlDataReader["state"]),
                        number = Convert.ToInt32(sqlDataReader["number"]),
                        quantityperson = Convert.ToInt32(sqlDataReader["quantityperson"]),
                        quantitybed = Convert.ToInt32(sqlDataReader["quantitybed"]),
                        amount = Convert.ToInt32(sqlDataReader["amount"])

                    });
                }
                connection.Close();
            }
            return room;
        }
    }
}
