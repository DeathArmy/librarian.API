using librarian.API.Dtos.UserBook;
using librarian.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Dtos.User
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<PlainUserBookDto> UserBooks { get; set; }
    }
}
