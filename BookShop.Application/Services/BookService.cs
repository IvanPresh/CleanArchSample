using BookShop.Application.DTO;
using BookShop.Application.Interfaces;
using BookShop.Core.Entities;
using BookShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task AddBookAsync(CreateBookDTO bookDTO)
        {
            var book = new Book
            {
                Author = bookDTO.Author,
                Description = bookDTO.Description,
                ISBN = bookDTO.ISBN,
                Price = bookDTO.Price,
                Title = bookDTO.Title

            };
            await _bookRepository.AddBookAsync(book);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllBooksAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookRepository.GetBookByIdAsync(id);
        }
    }
}
