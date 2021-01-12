using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Models
{
    public enum Status
    {
        None, Reading, Drop, Completed
    }

    public class UserBook
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Score { get; set; }
        public Status Status { get; set; }
    }
}
