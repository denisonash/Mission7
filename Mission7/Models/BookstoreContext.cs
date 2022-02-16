using System;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext()
        {

        }

        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            :base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
