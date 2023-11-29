using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cours_web_Api.Models
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Character>? Characters { get; set; }
    }
}