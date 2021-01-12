using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Dtos.User
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Hash { get; set; }
    }
}
