using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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


        public List<Room> Getsearchroom1(string date1, string date2, int typeroomparameter)
        {
            List<Room> room = new List<Room>();
            List<Room> roomSeason = new List<Room>();

            List<Room> roomFinal= new List<Room>();

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

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SearchRoom", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@arrivaldate", SqlDbType.Date).Value = date1;
                command.Parameters.Add("@departuredate", SqlDbType.Date).Value = date2;
                command.Parameters.Add("@typeroom", SqlDbType.Int).Value = typeroomparameter;

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
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        urlimage = sqlDataReader["urlimage"].ToString(),
                        descriptiontyperoom = sqlDataReader["descriptiontyperoom"].ToString()
                    });
                }
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SearchRoomSeasons", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@arrivaldate", SqlDbType.Date).Value = date1;
                command.Parameters.Add("@departuredate", SqlDbType.Date).Value = date2;
                command.Parameters.Add("@typeroom", SqlDbType.Int).Value = typeroomparameter;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    roomSeason.Add(new Room
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idtyperoom = Convert.ToInt32(sqlDataReader["idtyperoom"]),
                        typeroom = sqlDataReader["typeroom"].ToString(),
                        state = Convert.ToInt32(sqlDataReader["state"]),
                        number = Convert.ToInt32(sqlDataReader["number"]),
                        quantityperson = Convert.ToInt32(sqlDataReader["quantityperson"]),
                        quantitybed = Convert.ToInt32(sqlDataReader["quantitybed"]),
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        urlimage = sqlDataReader["urlimage"].ToString(),
                        descriptiontyperoom = sqlDataReader["descriptiontyperoom"].ToString()
                    });
                }
                connection.Close();
            }

            if (roomSeason != null || roomSeason.Count != 0)
            {

                for (int i = 0; i < roomSeason.Count; i++)
                {
                    for (int j = 0; j < season.Count; j++)
                    {
                        if (roomSeason[i].idtyperoom== season[j].idtyperoom)
                        {
                            roomSeason[i].amount = roomSeason[i].amount + season[j].percentation;

                        }
                    }

                }
            }//

            if (roomSeason == null || roomSeason.Count == 0)
            {
                roomFinal = room;
            }
            else
            {
                
                roomFinal = roomSeason;
            }

            return roomFinal;

        }

        public List<Room> GetAllRoom()
        {

            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectRoom", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    rooms.Add(new Room
                    {
                        id = Convert.ToInt32(sqlDataReader["id"]),
                        idtyperoom = Convert.ToInt32(sqlDataReader["idtyperoom"]),
                        state = Convert.ToInt32(sqlDataReader["state"]),
                        number = Convert.ToInt32(sqlDataReader["number"])
                    }
                    );
                }
                connection.Close();
            }
            return rooms;
        }

        public List<Room> GetsearchroomRecomendation(string date1, string date2, int typeroomparameter)
        {
            List<Room> room = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SearchRoomRecomendation", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@arrivaldate", SqlDbType.Date).Value = date1;
                command.Parameters.Add("@departuredate", SqlDbType.Date).Value = date2;
                command.Parameters.Add("@typeroom", SqlDbType.Int).Value = typeroomparameter;

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
                        amount = Convert.ToInt32(sqlDataReader["amount"]),
                        urlimage = sqlDataReader["urlimage"].ToString(),
                        descriptiontyperoom = sqlDataReader["descriptiontyperoom"].ToString()
                    });
                }
                connection.Close();
            }
            return room;
        }

        public void DateFilter(string date1, string date2)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SearchDateFilter", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@arrivaldate", SqlDbType.Date).Value = date1;
                command.Parameters.Add("@departuredate", SqlDbType.Date).Value = date2;
                SqlDataReader sqlDataReader = command.ExecuteReader();
                connection.Close();
            }
        }
    }
}
