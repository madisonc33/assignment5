using System;
using Microsoft.EntityFrameworkCore;

namespace assignment5.Models
{
    public class BooksDBContext : DbContext
    {
        public BooksDBContext (DbContextOptions<BooksDBContext> options) : base (options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
