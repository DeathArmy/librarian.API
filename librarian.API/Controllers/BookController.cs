using librarian.API.Dtos.Book;
using librarian.API.Models;
using librarian.API.Services.BookService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;
        public BookController(IBookService bookService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet("GetBooks")]
        public async Task<IActionResult> GetBooks()
        {
            ServiceResponse<List<GetBookDto>> response = await _bookService.GetBooks();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBook(int bookId)
        {
            ServiceResponse<GetBookDto> response = await _bookService.GetBook(bookId);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpDelete("{bookId}")]
        public async Task<IActionResult> DeleteBook(int bookId)
        {
            ServiceResponse<string> response = await _bookService.DeleteBook(bookId);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookDto book)
        {
            ServiceResponse<GetBookDto> response = await _bookService.UpdateBook(book);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookDto book)
        {
            ServiceResponse<GetBookDto> response = await _bookService.AddBook(book);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
