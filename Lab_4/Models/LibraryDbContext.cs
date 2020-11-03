using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_4.Models;

namespace Lab_4.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lab_4.Models.AddBookViewModel> AddBookViewModel { get; set; }
        public DbSet<Lab_4.Models.AddStudentViewModel> AddStudentViewModel { get; set; }
    }
}
