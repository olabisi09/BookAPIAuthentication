using BookAPI.Data;
using BookAPI.Entities;
using BookAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Services
{
    public class BookService : IBook
    {
        private BookAPIDataContext _context;
        public BookService(BookAPIDataContext context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            book.DateCreated = DateTime.Now;
            _context.Add(book);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Book book)
        {
            try
            {
                await _context.AddAsync(book);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var book = await _context.Books.FindAsync(Id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {

            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetById(int Id)
        {
            var book = await _context.Books.FindAsync(Id);

            return book;
        }

        public async Task<bool> Update(Book book)
        {
            var b = await _context.Books.FindAsync(book.Id);
            if (b != null)
            {
                b.Title = book.Title;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
