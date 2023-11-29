using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cours_web_Api.DTO.Character.User
{
    public class UserLoginDto
    {

        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}