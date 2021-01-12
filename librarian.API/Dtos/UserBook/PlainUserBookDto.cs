using librarian.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Dtos.UserBook
{
    public class PlainUserBookDto
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public Status Status { get; set; }
    }
}
