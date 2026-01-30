using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookMgt.Models;

namespace BookMgt.Data
{
    public class BookMgtContext : DbContext
    {
        public BookMgtContext (DbContextOptions<BookMgtContext> options)
            : base(options)
        {
        }

        public DbSet<BookMgt.Models.Book> Book { get; set; } = default!;
    }
}
