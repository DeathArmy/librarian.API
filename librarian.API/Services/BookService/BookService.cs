using AutoMapper;
using librarian.API.Dtos.Book;
using librarian.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Services.BookService
{
    public class BookService : IBookService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public BookService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<GetBookDto>> AddBook(AddBookDto newBook)
        {
            ServiceResponse<GetBookDto> serviceResponse = new ServiceResponse<GetBookDto>();
            try
            {
                var entity = _mapper.Map<Book>(newBook);
                _context.Books.Add(entity);
                _context.SaveChanges();
                serviceResponse.Data = _mapper.Map<GetBookDto>(entity);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteBook(int id)
        {
            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();
            try
            {
                var entity = _context.Books.FirstOrDefault(b => b.Id == id);
                _context.Remove(entity);
                _context.SaveChanges();
                serviceResponse.Data = "deleted";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetBookDto>> GetBook(int id)
        {
            ServiceResponse<GetBookDto> serviceResponse = new ServiceResponse<GetBookDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetBookDto>(_context.Books.FirstOrDefault(b => b.Id == id));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetBookDto>>> GetBooks()
        {
            ServiceResponse<List<GetBookDto>> serviceResponse = new ServiceResponse<List<GetBookDto>>();
            try
            {
                serviceResponse.Data = _context.Books.Select(b => _mapper.Map<GetBookDto>(b)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetBookDto>> UpdateBook(UpdateBookDto updatedBook)
        {
            ServiceResponse<GetBookDto> serviceResponse = new ServiceResponse<GetBookDto>();
            try
            {
                var entity = _context.Books.FirstOrDefault(b => b.Id == updatedBook.Id);
                entity.Author = updatedBook.Author;
                entity.PageCount = updatedBook.PageCount;
                entity.PhotoSrc = updatedBook.PhotoSrc;
                entity.ReleaseDate = updatedBook.ReleaseDate;
                entity.Title = updatedBook.Title;
                _context.SaveChanges();
                serviceResponse.Data = _mapper.Map<GetBookDto>(entity);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
