using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarian.API.Models;
using Microsoft.EntityFrameworkCore;

namespace librarian.API
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Book Seed
            modelBuilder.Entity<Book>().HasData(
                    new Book { Id = 1, Title = "Lorem Ipsum", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2020, 2, 1) },
                    new Book { Id = 2, Title = "Nulla congue", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2020, 3, 21) },
                    new Book { Id = 3, Title = "Etiam maximus", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2019, 4, 10) },
                    new Book { Id = 4, Title = "Integer dapibus", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2016, 2, 15) },
                    new Book { Id = 5, Title = "Aliquam nec", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2020, 12, 2) },
                    new Book { Id = 6, Title = "Praesent luctus", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2015, 11, 1) },
                    new Book { Id = 7, Title = "Nam porttitor", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2018, 3, 11) },
                    new Book { Id = 8, Title = "Sed placerat", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2019, 5, 10) },
                    new Book { Id = 9, Title = "In maximus", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2020, 8, 9) },
                    new Book { Id = 10, Title = "Nullam ac", PageCount = 0, Author = "Jan Kowalski", PhotoSrc = "", ReleaseDate = new DateTime(2020, 10, 11) });
        }
    }
}
