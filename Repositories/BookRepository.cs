using LMBookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMBookAPI.Repositories
{
    public class BookRepository
    {
        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books.ToListAsync();
        }
        public async Task<Book> Get(int id)
        {
            return await _context.Books.FindAsync();
        }
        public async Task Update<Book> Create(Book book)
        {
           _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book;
        }
        public async Task Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
