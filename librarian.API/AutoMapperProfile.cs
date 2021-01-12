using AutoMapper;
using librarian.API.Dtos.Book;
using librarian.API.Dtos.User;
using librarian.API.Dtos.UserBook;
using librarian.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddUserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<User, GetUserDto>();
            CreateMap<LoginDto, User>();
            CreateMap<PasswordChangeDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<UpdateUserDto, GetUserDto>();
            CreateMap<AddBookDto, GetBookDto>();
            CreateMap<AddBookDto, Book>();
            CreateMap<Book, GetBookDto>();
            CreateMap<UpdateBookDto, GetBookDto>();
            CreateMap<PlainUserBookDto, UserBook>();
            CreateMap<UserBook, PlainUserBookDto>();
        }
    }
}
