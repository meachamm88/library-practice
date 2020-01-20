using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryPractice.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

    }
}
