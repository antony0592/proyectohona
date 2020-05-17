using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserDTO
    {
        public UserDTO(string id, string email)
        {
            Id = id;
            Email= email;
        }

        public UserDTO()
        {
        }

        public string Id { get; set; }
        public string Email { get; set; }

    }
}
