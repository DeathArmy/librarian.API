using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string PhotoSrc { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        public List<UserBook> UserBooks { get; set; }
    }
}
