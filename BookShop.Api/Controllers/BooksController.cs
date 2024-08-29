using BookShop.Application.DTO;
using BookShop.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(CreateBookDTO createBookDTO) 
        {
            await _bookService.AddBookAsync(createBookDTO);
            
            return Ok("Book was created succefully");
        
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks() 
        {
            var books = await _bookService.GetAllBooksAsync();
           
            return Ok(books);
        }
    }
}
