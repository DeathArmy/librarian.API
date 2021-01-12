using librarian.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=librarian.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many-To-Many --> UserBooks
            modelBuilder.Entity<UserBook>()
                .HasKey(ue => new { ue.UserId, ue.BookId });
            modelBuilder.Entity<UserBook>()
                .HasOne(ue => ue.Book)
                .WithMany(b => b.UserBooks)
                .HasForeignKey(ue => ue.BookId);
            modelBuilder.Entity<UserBook>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.UserBooks)
                .HasForeignKey(ue => ue.UserId);

            modelBuilder.Seed();
        }
    }
}
