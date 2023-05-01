using LMBookAPI.Models;
using LMBookAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LMBookAPI.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
    }

    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }


    }
}