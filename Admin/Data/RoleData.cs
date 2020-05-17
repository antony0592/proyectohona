using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class RoleData
    {
        private String connString;
        public RoleData(String connString) 
        {
            this.connString = connString;
        }

        public List<UserDTO> GetUsersByRole(string nameRole) 
        {
            List< UserDTO> users = new List<UserDTO>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectRole", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    users.Add(new UserDTO
                    {
                        Id = sqlDataReader["Id"].ToString(),
                        Email= sqlDataReader["Email"].ToString()
                    }
                    );
                }
                connection.Close();
            }
            return users;

        }

    }
}
