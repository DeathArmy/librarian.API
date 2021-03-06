﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public List<UserBook> UserBooks { get; set; }
    }
}
