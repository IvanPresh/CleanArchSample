using BookShop.Core.Entities;
using BookShop.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly MyBookShopContext _dbContext;

        public BookRepository(MyBookShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task  AddBookAsync(Book book)
        {
            // Adds the new book entity to the database context
            _dbContext.books.Add(book);

            // Saves changes asynchronously to the database
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
           return await _dbContext.books.ToListAsync(); 
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _dbContext.books.FindAsync(id);  
        }
    }
}
