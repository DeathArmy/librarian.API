using librarian.API.Dtos.Book;
using librarian.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Services.BookService
{
    public interface IBookService
    {
        public Task<ServiceResponse<GetBookDto>> AddBook(AddBookDto newBook);
        public Task<ServiceResponse<GetBookDto>> GetBook(int id);
        public Task<ServiceResponse<List<GetBookDto>>> GetBooks();
        public Task<ServiceResponse<string>> DeleteBook(int id);
        public Task<ServiceResponse<GetBookDto>> UpdateBook(UpdateBookDto updatedBook);
    }
}
